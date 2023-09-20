//----------------------------------------------------------------------------
// Encryptor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// Class used to perform two-way encryption.
	/// To use it, start by setting the Key and Salt properties,
	/// then use the Encrypt and Decrypt methods.
	/// </summary>
	internal class Encryptor
	{
		//---------------------------------------------------------------------
		#region ** fields
		private string _key;
		private string _salt;
		private SymmetricAlgorithm _cryptoService;
		#endregion

		//---------------------------------------------------------------------
		#region ** ctor

        public Encryptor(string key, string salt)
        {
            _cryptoService = new RijndaelManaged();
            _cryptoService.Mode = CipherMode.CBC;
            Key = key;
            Salt = salt;
        }
        public Encryptor() : this(null, null) {}

		#endregion

		//---------------------------------------------------------------------
		#region ** public

		public string Key
		{
			get { return _key; }
			set { _key = value; }
		}
		public string Salt
		{
			get { return _salt; }
			set { _salt = value; }
		}
		public string Encrypt(string plainText)
		{
			byte[] plainByte = ASCIIEncoding.ASCII.GetBytes(plainText);
			byte[] keyByte = GetLegalKey();

			// set private key
			_cryptoService.Key = keyByte;
			SetLegalIV();
   
			// encryp
			ICryptoTransform cryptoTransform = _cryptoService.CreateEncryptor();
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write);

			// write encrypted bytes to memory stream
			cs.Write(plainByte, 0, plainByte.Length);
			cs.FlushFinalBlock();

			// convert into base 64 to enable result to be used in Xml
			byte[] cryptoByte = ms.ToArray();
			return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));
		}
		public string Decrypt(string cryptoText)
		{
			try
			{
				// convert from base 64 string to bytes
				byte[] cryptoByte = Convert.FromBase64String(cryptoText);
				byte[] keyByte = GetLegalKey();

				// set private key
				_cryptoService.Key = keyByte;
				SetLegalIV();

				// decrypt
				ICryptoTransform cryptoTransform = _cryptoService.CreateDecryptor();
				MemoryStream ms = new MemoryStream(cryptoByte, 0, cryptoByte.Length);
				CryptoStream cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Read);
				StreamReader sr = new StreamReader(cs);
				return sr.ReadToEnd();
			}
			catch
			{
				return null;
			}
		}
		#endregion

		//---------------------------------------------------------------------
		#region ** private

		private void SetLegalIV()
		{
			_cryptoService.IV = new byte[]
			{
				0x0f, 0x6f, 0x13, 0x2e, 0x35, 
				0xc2, 0xcd, 0xf9, 0x05, 0x46, 
				0x9c, 0xea, 0xa8, 0x4b, 0x73,
				0xcc
			};
		}
		private byte[] GetLegalKey()
		{
			// convert user key into key that is valid for encryption
			if (_cryptoService.LegalKeySizes.Length > 0)
			{
				int keySize = _key.Length * 8;
				int minSize = _cryptoService.LegalKeySizes[0].MinSize;
				int maxSize = _cryptoService.LegalKeySizes[0].MaxSize;
				int skipSize = _cryptoService.LegalKeySizes[0].SkipSize;
				if (keySize > maxSize)
				{
					_key = _key.Substring(0, maxSize / 8);
				}
				else if (keySize < maxSize)
				{
					int validSize = (keySize <= minSize)
						? minSize 
						: (keySize - keySize % skipSize) + skipSize;
					if (keySize < validSize)
					{
						_key = _key.PadRight(validSize / 8, '*');
					}
				}
			}
			PasswordDeriveBytes key = new PasswordDeriveBytes(_key, ASCIIEncoding.ASCII.GetBytes(_salt));
			return key.GetBytes(_key.Length);
		}
		#endregion
	}
}
