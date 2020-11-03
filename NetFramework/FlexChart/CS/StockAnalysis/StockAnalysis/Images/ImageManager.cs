using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StockAnalysis
{
    public class ImageManager
    {
        static public Image GetNamedImage(string name)
        {
            Image image = null;         
            switch(name)
            {
                case "Amazon":
                    image = GetImageFromString(ref AmazonImage, AmazonImageString);
                    break;                  
                case "Apple":
                    image = GetImageFromString(ref AppleImage, AppleImageString);
                    break;
                case "Cisco":
                    image = GetImageFromString(ref CiscoImage, CiscoImageString);
                    break;
                case "Dell": 
                    image = GetImageFromString(ref DellImage, DellImageString);
                    break;
                case "eBay":
                    image = GetImageFromString(ref eBayImage, eBayImageString);
                    break;
                case "Google":
                    image = GetImageFromString(ref GoogleImage, GoogleImageString);
                    break;
                case "Intel": 
                    image = GetImageFromString(ref IntelImage, IntelImageString);
                    break;
                case "Microsoft":
                    image = GetImageFromString(ref MicrosoftImage, MicrosoftImageString);
                    break;
                case "Oracle": 
                    image = GetImageFromString(ref OracleImage, OracleImageString);
                    break;
                case "Vodafone":
                    image = GetImageFromString(ref VodafoneImage, VodafoneImageString);
                    break;

                case "Settings":
                    image = GetImageFromString(ref SettingsImage, SettingsImageString);
                    break;
                case "CheckMark":
                    image = GetImageFromString(ref CheckMarkImage, CheckMarkString);
                    break;
                case "CancelMark":
                    image = GetImageFromString(ref CancelMarkImage, CancelMarkString);
                    break;

                case "C1Logo":
                    image = GetImageFromString(ref C1LogoImage, C1LogoString);
                    break;
                case "StockAnalysis":
                    image = GetImageFromString(ref StockAnalysisImage, StockAnalysisImageString);
                    break;
            }
            return image;
        }

        static public Image GetImageFromString(ref Image image, string imageString)
        {
            if(image == null && imageString != null)
            {
                using (var imageStream = new System.IO.MemoryStream(
                    Convert.FromBase64String(imageString)))
                {
                    image = Bitmap.FromStream(imageStream) as Bitmap;
                    if (image != null) ((Bitmap)image).MakeTransparent();
                }
            }
            return image;           
        }

        static public Icon GetC1LogoIcon()
        {
            if (c1LogoIcon == null)
            {
                using (var icoStream = new System.IO.MemoryStream(Convert.FromBase64String(C1LogoIconString)))
                {
                    c1LogoIcon = new Icon(icoStream);
                }
            }
            return c1LogoIcon;
        }

        #region Image Declarations
        static Image AmazonImage = null;
        static Image AppleImage = null;
        static Image CiscoImage = null;
        static Image DellImage = null;
        static Image eBayImage = null;
        static Image GoogleImage = null;
        static Image IntelImage = null;
        static Image MicrosoftImage = null;
        static Image OracleImage = null;
        static Image VodafoneImage = null;

        static Image SettingsImage = null;
        static Image CheckMarkImage = null;
        static Image CancelMarkImage = null;

        static Image C1LogoImage = null;
        static Image StockAnalysisImage = null;

        static Icon c1LogoIcon = null;
        
        #endregion

        #region Image String Declarations

        const string AmazonImageString =
                "iVBORw0KGgoAAAANSUhEUgAAAD8AAAAcCAYAAADWZ2dHAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAATVSURBVFhH7ZdNSGNXFMfPlFk8IYsIFiKk0AcW" +
                "qnSgEYXGXYUuqquJTKFKF9Mws2gcFzW4GNMuhkwLRVsoY7uosTBFC5U4UFChkrgYSAozmAGLWcwi" +
                "AxUMjJBABQMjpP//eS/x68WpNkM/4g/Dfefed8+7556Pe72w+8duWRqUC2VgPzccL9ltQ3JufKPS" +
                "0MbXLHiZRxmJL8S1LTwtSGd3p4yOjIrZZup4ZCws+e2iRG9FZeKLqGSf5CRwOSDBq0GJfReThXsL" +
                "Yr5qSuRmRDxej87J4Z25H+Yk9SDlqLO0U5Lg9aDIXknlCh2XOmX8k3F9Tq8mJfbjnOryd/ll+KPh" +
                "qv6pb6ckhfHwWETW1tesNXhNXaO7xa3vHMTReBo8cHkAi9jFpFYpFovV57UHayIXRXr8PZLfzEm7" +
                "r1OyGfTZ9GHe0r24LYn4unt0E6mj9+1eKW5vieFuhqUl/B3Wmc/npafbZ8/cx3ytQxLJhG5c5Oao" +
                "9hmuZmxWQefzex5s9NB7A5JOp46tgd+dvjtrS/s4hj0XS2MH3x+SNRiWWE1oPxe+tLykzxWMi4ZM" +
                "fD2liyBJjI/C21wAycDLJLmS1Pnt8OJGZgPycZ0ejwdRkZFUOoNomtQ+EroWxEaVJIoIIxzbWN8Q" +
                "Hzae8/n9g/Bb0zOzErgyZMn309oeg56vybNyGR8pJ35JlE2vR3/xn+I65H/Lr/Liz4sqj94IqTx4" +
                "JaByKp2qzjnKRtZZZ4VCoVD2d/l0LHgtqH1wQvX9rd+3tG96Zlpl35s+lfltnXPVmnPSGoij55l7" +
                "4Y/DyLUOGR4Z1typRfPLCGGCCCCtyDFH9kRuf35bdbIunKQzzHqS30IktMLLE9qXy+W0JZUcb0bo" +
                "E3r/IKZZYw1HcDQ+eisiC/OzmivMtTvf3LFHzg6LUQx6zFdMSd1P1dTJvE4uL+rz5FdIJ7dVqA4a" +
                "ROeQLdQcUkm5Cm6X5Yjn4Wg8iwapfDDzMKMtYZU9CwhBbVtZdVHcnHTmN/MS/czKaxrE2sNNYyFs" +
                "f73dKpRgacWqEZlsVlueGmfB0XgPvENid2Ma9sg7LLip2ncWTK9dEFF8eDw56VxcWdQKThjKjL5J" +
                "bAYj0DAMCV0P6RiP2f6+fo0QVv3xMesYPC2Oxkc+jUjvO/0aXgzR4IdBiePo4JHDM5w0wXvE7bLC" +
                "0rBlww65Sn/FwGHUkABOABrBKBgaHDqmk3WBcmgkLBNfTumpQcMrhG6EtM/d4pEsvM5qH5+HDvue" +
                "0GTXgEr94bcUew1HcTzn/xXs4W5RQhS4GDF/LYdPy+mNLyJXN5MibzAE67wo3uweRkSyiAQaTwxU" +
                "9g8OV/O6QeNPzePpcnnOLJfXJyDsWn314lnB+pEsvjNjWM8vAMecfy5tKFbv4jhax83qe+TZKm5S" +
                "T3huH76Tn4o8ounXsMg8Kvcq9CvQ59nP+XrzN3Mei/sNG5DBRaSUh4w0aMHdvLUHLYxwoRC5ELYs" +
                "OAzfEvMYIczfDt5n+xT3+k0cXRzj+9046toGLfXL/SKXkF7ePkuuM3UqePYmPMb/BNs17tEnQe+2" +
                "w9ttAQh2HWHOP8Kmdlnn/oug/tWeEbCJlMjRm7aHd3L2IKB3DRyDjA43osQLw9n3D1B/4/9DnK3g" +
                "/U84N75ROTe+MRH5E0GJjyCDl4/mAAAAAElFTkSuQmCC";

        const string AppleImageString = 
                "iVBORw0KGgoAAAANSUhEUgAAABcAAAAcCAYAAACK7SRjAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAFoSURBVEhLY/wPBAw0AkxQmiZg1HCsYHAZ/uHD" +
                "B4acvByGmroaqAgeAEqKpABDA0NQ0v0/ZdoUqAhuQJLh506fAxsMsuD79+9QUdyAqGD58eUHhP7z" +
                "g6G4sJjh2OFjcDF8AKfhIM3RcdEMgqKCDJyCnAxWllYM+3bvYzh/5TyDpKwkWFxJUYmhtbkVqgML" +
                "gPoABXz//P2/pY0lOAiIwUsXLYXqRAVYDQdFFjZDsOHs3GyoLkyA1fCoyCisBmHD9+7fg+rCBFgN" +
                "V1RQxGoQOhYQEYDqwA6wRihQE5SFH3x48wFvqsFquJGuEZRFGLS0tUBZWADUByigp68HazBgxSwM" +
                "/4tLi6E6UQFWw9+/f/9fQEAAu2FYsJOjE1QnKsBqOAiQ4vq9+/ZCdaECnIb///3/v6UF4YxEcjqH" +
                "geePn/8PCg36z8HBAbaourL6f3Ji8n9NDc3/HDwckLAGOgIXGK39sYJRw7EABgYA51r6ATai3FUA" +
                "AAAASUVORK5CYII=";

        const string CiscoImageString = 
                                       "iVBORw0KGgoAAAANSUhEUgAAACgAAAAcCAYAAAATFf3WAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                       "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAJTSURBVFhH7ZZNaNRAFMef0kMKPWRBYQUPLqxg" +
                                       "BaERBSOeFnpoixell4oHKXj0oFUQqgepl6I3i+DHsV4EBcE9KK0HYfZSZgUlKVSSgkICFpKDkAEL" +
                                       "48x0Wnfi7mSTFSxlfxD2vZf3n33Mx5vsowzYxeyXv7uWfoG90i+wVwoV6K6H0spHIR1vM3nArkfN" +
                                       "sSnpdU9RXe4ZJJtEWvkoqsss0A9jmLh+X3oqunec+CeBS3cfSk8lS7tN2wL5wAuv68IONwJAq46w" +
                                       "0/z1bhPgudRx3HUf6itYeiqKNqVrpW2B9UYTZp8uSq97GqsuzPxjXdsCKwdNMIxBYZtDJSgNbdlp" +
                                       "0u/Kpt5vpVWry8t9itFnp9BpLKrLfYp1M6pDO0sa9sjnFjtl5IsL5Kv/x/+euhV47JPLWkAsA4y0" +
                                       "jrMRA1lheaTLvigWWscvdgucu0CROSweTvIR79iCHxFFR2yKqzb1bs6JUPItoPjUuKIL5p9RdMAS" +
                                       "Ps9NGljEdWQWGL1DFB+ricGSNU/E0gVGb5YoKlvKHzqXbyi6hF11XOPdeUCTpkOd0SmKR8Zldmcy" +
                                       "lzh6vwymbYFxhj3VioyqmKNnoTxWg+b5afCvzooYWfMVHfc5lWvTYIwMQ2lyAghr5FlkFjh4tALh" +
                                       "BwTh4xcQd+j2wG6eQ/dmoHzlIoQyx7RPKjrjxHGAAQP8W3MQv6xD8GQRzNOWyNUiZ7IzbA/yZcHV" +
                                       "GkWHLRFKL3Ew/0juq5qwBVFEvdtcZ+/ooldvt8ZhuXyJt7cMh2+BduyRNvMf6RfYK/0CewPgNwRB" +
                                       "bY5/yAS2AAAAAElFTkSuQmCC";

        const string DellImageString = 
                                      "iVBORw0KGgoAAAANSUhEUgAAADEAAAAcCAYAAADIrlf0AAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                      "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAKkSURBVFhH7ZVPaNNwFMe/Ew8RdkhBIQE9RBRM" +
                                      "0UPGPCh6WIeHKbusJwt6cCKo87LqQNxJpheLA7F6WT0IxYNsO4i7jNVDwR6URVCM4DCCQgMKzWFg" +
                                      "D4K+X/IrabKsf2CFFPKB0uTx45ff9/e+772BfwT6nF38v6+JRUSFWERUiEVEhdA5Mbtq8ScXeQ+Q" +
                                      "GBSg7hWg7Rd4NJzS9zqmXpqYHE4gOyLxqItdB3Jlb28lIdA6kb+5LH2ysV6lhZz0MRGa1PqboSIG" +
                                      "pnX+tBUpAdwckZE95T9g/S/FX1nIl6s8AhIhIzfurTNt4OBdb+/UYQFrV1X+5nL5hYnCO1rIWcgo" +
                                      "W4QG6dpOVo0Ou1TF1LLJI+7tJx/onoDdwJ0xGbNnJGcdu91e0l4EHUgMyWa+bKO0QdZZtjD6yID5" +
                                      "y41rBwSsT6s4p4oYmmfCbKSfmU6WekVbEQrZp3Zfw9o1Fco+v5rRJ4bPPuz2395QsajbONkkLHNc" +
                                      "dLKi/+xNRjq2U+qQgOxpUtSCykYNqacG7q2SMKoRlsHiRQXF8wpybyykn3sW3Em6qgmFulMrSl/r" +
                                      "qJhuZ2FFa8xoOEHdbGjeE9YLOhbB2mO+QlXdIdVNoKBbSD40oP9whQlUX72gbYtlH2bFWmEHCdzk" +
                                      "4iUFKx9rvpa4HSwzc2OKUysN2N5yk0MnjsqwN//49hMHaUbRnGrw7bbGnzzaZoL1f8ciAQEZTaSP" +
                                      "ilggv7++ojjzIwx20McTsjMPpECbY3uz4m/8mIAgNmW0eU0YXdUEQ6KbyY3LKF5QeAQ4e0SEcUvD" +
                                      "JHWhZpx2O6PiemAw7jShdiq8D7dHksY/K9RWrHyxnQGXGZYxR221GXbzxQ/bWy/JG8fn324NhRE2" +
                                      "vUNF9Btd2ymKxCKiQiwiKsQiogHwH3G47/o3Vy7HAAAAAElFTkSuQmCC";

        const string eBayImageString = 
                                      "iVBORw0KGgoAAAANSUhEUgAAADIAAAAcCAYAAAAjmez3AAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                      "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAP5SURBVFhH7ZdBaBxVGMf/kQov0MMUUtiFCA6k" +
                                      "4AYLLiiYYg5ubisekmAPCQo22kv0ovZig6d6qRGhNHrp6qk5KFlByRYqWQ8rGyFlpwfZFQSnEGEW" +
                                      "EpiBFOZBA6//9+at3d3u1uCl27I/eHlvvu/tm/nP+77vTUbig1jhKWBEETt+onnG9k88QyGDxlCI" +
                                      "ZuRcAzNf+Pbq8TLckUHjv8+RWx6kz/CREiKTAV5gOy6MS4dWLiOwdcGFvw94/0iEnDeZEsiOC4hj" +
                                      "ZlondxsP2jGHa3G9sRyXbxq3ECnT9+JRc/oKkb9uQ361Crlrc0CcoDE0vfPRMsRbc0bI1CmByfFR" +
                                      "FCr0HSZTNakxoPCOi/yLiWgcRnwpi5BBKbkWFCFp0zhZFJ4FogMfuVMrmJr4OLG30Wiuo+gtwz2Z" +
                                      "w8LLG9bahhbyELuBCl7NmRZ/v6HUXqjUPaXiclWFs3MqeClrxni3bprzYV1teLGKOSeMlVq9GSq8" +
                                      "Tx9bPaBB4y2ruMjbbee5lrUd1JXamTP2eiWnLpUctVp2uY71t3G1kjX+IKxaSyc9hcSXV5OH/WnT" +
                                      "Wtrw6sYXvr30r5Ctvx6+8cUixdCXv/J3YogDNo67H/JeaITEpZS6tp2IqfnXrDOhHmwa+3WK7kfP" +
                                      "0IrOvQfp1SDOLkKMMQTaYQ5E3xYY3wLp0wUTQsFlxnkXDYbz5KcNOMeB8Ir2S2C/CjSLJkRb8W7Y" +
                                      "K5sumN7C+s48HJHG8ut1Y9MUfp9BM6xhaaqElDNlrZ30rFqyGSR9pQz5Y6mz3ShDpF2Ik2kzxz1h" +
                                      "c6ALlwI10V39V0L+xoSuzLBw8CUwXwSTXDDJdWvhcqxzIJIBvDucR/z9khGh7f1EGMy+dKHDRoeP" +
                                      "2qlZS29a+dGLqs9/D+h3L9C/t5mEz03XhFIHrdDS+UN0DugwulrOmOtWuPXLjRY9d0RMJ8qj9eum" +
                                      "b0feKCE6/wEr2pfmWr/xz3+21aeNlR+SXZ17RVc769flVrd27qzZQYJ+65l03uxK8fbi0XaD9C6/" +
                                      "LKPR2Xlzfohpbv+beT7AKHC7SnFJ6Ut9s4aRr4XJgYjhv8AHPjMhIPlbXYobPFMyPEtqnzEMD5ss" +
                                      "58wTChLPLQDj8xyzXO8zdHV+HHIBHW6zyaNEPGPWKmfMWPOo3GjR9xzRYuR3BchfeLNdJiZvLFwX" +
                                      "mMjAOb/E3jXfWdnnR5HPOtyVADWfhYA7pAXkT4/i0mzqwaEY8WD98xMmNhNePzgPNZF+gwfsReCP" +
                                      "FZP84rUtOxlYvzUPnyL7nhtd9BfyGJEUulaZpLjwSLuhGchvLY95o0UcJTdaDJwQvRvV3aQA5CYY" +
                                      "ikdkIEPr//DUfMYPhQwaQyGDBXAfa0dMu9rfb38AAAAASUVORK5CYII=";

        const string GoogleImageString =
                                        "iVBORw0KGgoAAAANSUhEUgAAADsAAAAcCAYAAADfjMc9AAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                        "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAARNSURBVFhH7ZdBSFxXGIVPi4tbsPAGDChYyIAF" +
                                        "FRdxqJDJzgEXTemiA1kkoYtUEijaRWm6CJQuyjSLMm7STDfRZlG0izBmUdRFyLhoiIWGMWBBQWGE" +
                                        "DmSgAQc60LsQmnPufWPG8SVBbIw1fnC5zn0v797z///538sb/xK8JrwZzq8FR2IPK0diDysv7Mal" +
                                        "x8DsIrBcttiwQLwN6H3HIP0eYFrCm/aJQnkRpWoJw33pcGV3PFfs1D1g4lcqJIEBYq1evGgPgMwZ" +
                                        "48TvF98+yCG/WkDxbD5c2R3PLOO6UIm5fsEg/7nB+EWDu18ajAwZdFCsxv+JSLHKnoQqe+MU2tMe" +
                                        "XhAsXZVw9qzZ9zLeK5Fi5VExygxK3K4ol2DnpmFvTwNrpXCxAcu1ygTvywG15XBxO5bOWVgBph/4" +
                                        "wFeqwGI5vNjMJsdvC7C3ptz8PCI9O3rTYrkCzLB0DfXW0cZVb+Ft9Hf62X4/BvvLpD9AiBk8DXMl" +
                                        "44O2Ngr8SaGbDQ/pOAf0cQ1+I4nK3Lao1txPR8Beod+poYntnl0vofrNZTdv0d2D4CoDGez0WGTe" +
                                        "1HVFo1CRm7OREb57xTCTUxyTXtyZ83wy1+ZnYX+mkLYYzId8WImHkLjjPKDEKcOlMf7ZAXRlnaDM" +
                                        "LQttr76gIM4uKcMRESZOaK2K4Ds+t7vf7W9v5lD9+jKCa+PhXU+JLOPe0KMlZreR7MdsUBRWH4q4" +
                                        "hrBzMy465jMegNFFVxzm4gjnHl6b9cIYAHRTXGs/h+7JssXzb2WbFFi6qpz0Cf9qi/McI0O+8+9A" +
                                        "FmFGzUAKdqmI6icfwP6UgzmZQnBuOLxpO5Fik+/6lObmoyMq3MGYiVPHw/TLaC1vUUTTyQzXNv/h" +
                                        "oPGUzZbmk+vf+31Kf7kJibif6yTqezRi9TwFOe96hHk/jWCqAHOVATyZdNeaiRSb6uPopn/W+W5r" +
                                        "8o9YWGMg7ljXjYcH/ZrpYaZqG27jLdbYgFaKzGAvS4AHkOAyPV2nxk74N8fbzC6JH3MT7q/6uU5x" +
                                        "PSLorBjns9YYgh/zMBdYRW2Bb4yPfSCaiWxQQokao0eVQaHXj0pWjUvitc9X9GGyy19HpYLqJXqV" +
                                        "gnEiAcMM23sF1xWCH9hQOpnhBR5Qgo+lfIYf8WAq7QEGhGWt556/4YWlBwwzSs/+/vQMzQ1K/cDe" +
                                        "oF87aZnkKdhVBvdh0ZWyy3ATzxRbR6+AmSV2ZzYm+UkfGfF2flgwo3W/bkHB9loW9uF9/7svgeDS" +
                                        "F86/DstIrdBPG+H1WILXrnv/hqiaXDduSKY8q9fPjm5M7J2wCaojM8tmkEI/5Z7N3ZW8UOyrQFUl" +
                                        "0Y+Y6X5mV5ZRsGf49bYXIj37qlAZq0dM8mMiyZ6hjhyjPgn/L77BD1xmJVYeVUY7+L+Pwh987/Ij" +
                                        "JfMR+wMDsBcOnFgJm5jnq40i6z0inTQ4zTfEXjmQnn1ZHCjPvmyOxB5WjsQeToAnkhG8ASpbSj4A" +
                                        "AAAASUVORK5CYII=";

        const string IntelImageString = 
                                       "iVBORw0KGgoAAAANSUhEUgAAACsAAAAcCAYAAAD4IkbVAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                       "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAOMSURBVFhH7ZZBaNNQGMf/iocUPKSgkICCkQlm" +
                                       "eLDCwIkXFQ86PLihhxU9uJ2cHsQhyDYPOr24edDpxQ1B6DzI9CBWcDgPwioozcDRCMoiOEhgQgMK" +
                                       "CSjE73tNZ9ulW+esKOwHJXkvLy//773v+/etCQj8J6wNr/8Fq2LrxarYevHH3MD/AUx+8mE6Lqy8" +
                                       "B+sLYLk+3G9+OKKAtA5QZQka/RQ5hhZdRvMWKXy6OCsSO/HRRfpdHobjCxF7GuLQN0pCjLKeBYUD" +
                                       "S+Cg7G+AQ4FMfHDx9H0epu0jmZDRe0ij98KBESxbLAtLvbHFBzVamf3bZOyhlWGxv4v1xUfnQwvZ" +
                                       "zz76D6vo2quETypgsUvhfQ+CmXwQ5L0gmLQ80V4puTkvePGBJizh/KOZAOcmqZ8+FsGSYu2vgZiU" +
                                       "J+lJ22FvNFnbE2M4sKXoGC0I48D7Jwrz8r3Slw0SN3KiXcmibjD40sHYlINGRcJwu442yivGcn/9" +
                                       "KPXmyc76uDpu4dG0Q/lcXlgGPXModSrh9OnZV9h2vm9UpQVFWaSq2KvjDlW3J/InR3naOWpizCB1" +
                                       "xNbLGTRey+DALQPqpQx2XTfKRA88t9H5wBT33U8sGmNg/x1TjO195oj+atg8UZX8jxTLq5J6ayN1" +
                                       "Qgt7FpJMKJjpS2DouA6Dqjk9XQiESZ3UxbP0e1fsTrJJxtgpHR1NCrWtyBVmRqdcmHM+OnarYU85" +
                                       "kWJHqNpbd6rLqnAvvJbClsRwtY/SnAwHyf5bychbF8n7JprJ74ppUUmk2Az5p0Z+WUSN8Mso1NAj" +
                                       "WRjvDtsaI62T0N4Up3YcCS2G5k0S5BI/bbtnijTraFYweVYPexcSKVYmQ7doO4roGyQMHNHQGAbA" +
                                       "IjQlJu5ZILf5eni7jH4al/cLhZYgUS9O64jTa2ceWxjK2HDDLejep6HnYCHNdCWO3IUEho9VTztB" +
                                       "6ApldJHfyRezwQx5Yb1h766VyJXtpYjF3+dNc4EF/QkyZGPsCuoVAwNUgLVS9e/WJLtquWvSocQX" +
                                       "SZ/knGuQRUrUCteRScXFBcZplXM8pE2X+gsLoFB+3D6qoXVHbUWx6NmADx2DrxyMvLbLclijjyjh" +
                                       "ySlW4RicryyOLYjfL4V3K7FZpqDjyzptFan5IMMHGF7tHNmRMUsnJRKECjHzkCjeAQ5G2xATzqJR" +
                                       "m/uWY4eVrOiI+LeJLLB/lVWx9WJVbH0AfgKRK0IZjYf9NQAAAABJRU5ErkJggg==";

        const string MicrosoftImageString =
                                           "iVBORw0KGgoAAAANSUhEUgAAAFQAAAAcCAYAAAD/YJjAAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                           "jwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAQLSURBVGhD7Zg/aBNRHMd/SocEKiSgkIMKntDh" +
                                           "pIIJCibYwUAdWioYJxvqYHCQgIMEQQpO0akqCEUQomBpnFJBaRyEOCiJUEkGpSdUOKGFC1hoQYcM" +
                                           "hXrf392lF30JKkccfB84kvfu/S7vvr9/j+zZsSCJb+x1PiU+IQX1GSmoz0hBfUYK6jPCLt86e9j5" +
                                           "JqZ6f4oqq7ec0a/kx/7fg4OMUJ+Rgv4G+kedKq8r1Precma60xdB9U86zT2Y46vV+nVTjfcNvlec" +
                                           "L/K48qpCues5nv/XFJ8WqfCowHsyN0xntjt9ERSeNVYNvkQilV+V7fvrBo+D+4KkHFCIBnj4z4Dz" +
                                           "6406JeIJyt/OkxJR6M69Oz0d3deUDx8IU3W56oxsEL2bXzcpMBhwZoiix6KUuZyh6EjUmbHBCxpf" +
                                           "jHaUb21tdXxvs03UXG92znkQ3cNzMN9Oa+sZ2Bs+Q/tDvN5smmSumbT5bbPrs/vS5eHRheICjU+O" +
                                           "U/lFmXLXchQZivA9pDk2CkGxyZkbM5xm9eU6pafSFD0e5ZcsPC6QYdgRDMdgHZ4Ti8bsFzVNmr07" +
                                           "S7W3NSo9L7EQQDuqUWY6w9GOe0vlpbYTsB6gPpZfljtsEJWFhwV7oguuvZe+RmjsaIyFc6MUQtU/" +
                                           "2CnVCxZzzaDEaILSFy2RPZEL+1AoRMmxJEdUabFEqqryOqzXP+i2WBYQUzmoUPZqls6nzvMcbOBk" +
                                           "bVhjm9iJGNvous7PBNgfnIuA8I5FCKtU/vaK801MPlSlpOoM/gTr1xInElStVSk1mWoLiyiEMCKa" +
                                           "zSZHJl4idS7FcygJLoFAgMsDgPAgfSHNImMdSgR+D2K0tlvsxGAgSPFTcV6Le9hXejrNz3JtUDsz" +
                                           "lzLcjOAg7BEZBPHdsQhhhN5qtHpetFEhMqyU73b1AMIg5RofG1R7V+MxXqQb5rrdWdVhsQePDB9x" +
                                           "vll1dGOLMwBiuqCR4PdwZS5muP4hVRefLXKKw0ZRlI49qIfU3Vr6h/Q15QEKPMSB59GMELG9wHqA" +
                                           "U4AQT45hLYTwNgw4BGLh0kY0yt/MU3I0SdU3VXYqbFB/3boKEKGo093wrv2ZvgsKEJV4CdQztzl1" +
                                           "Qx1SOYJQHhBVOGRzdAlwnYPURwPihmf9TvJ0kkVGs0PNROoDRC/bWJGKczBsYAtHx0/aJcELIh8Z" +
                                           "gPKEfYjoi6CIDq/H0VQgEiLFJTwYptCgHY34xHpOQysCs1eypGkad36cFtwIwRrXBiAC0WxwH81p" +
                                           "ZXWFayeaC56FyMMh3fhs8HwkEtm1sSIbNqjXbGM5ITgQ3N2Hw8SZCXZS4Yn4BCA8Nu2ZF5+xXHbi" +
                                           "1nGhV62Uf45I/EIK6jPClJf8PTJCfUYK6jNSUJ+RgvqMFNRXiH4A4bkpQlCwCU8AAAAASUVORK5C" +
                                           "YII=";

        const string OracleImageString = 
                                        "iVBORw0KGgoAAAANSUhEUgAAAGoAAAAcCAIAAAAGOL0cAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                        "jwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAATGSURBVGhD7ZhBaBtHFIafSw5zcEEFHxRowAou" +
                                        "WMWFKNgQBV/i4oMdEoiCLyk9NHEPrttA4rjgyunBmByM64Pj9FLXhRa7ULALLXGhxcrBxSqk4EJC" +
                                        "FUiwAik40IANNWighen/ZkYrabW7Ur097seg3Xn7Znf09s2bX2pRSlHEYXnJHiMORRS+UEThC0UU" +
                                        "vlBE4QtFFL5QROELhb/u+yVPa6v0qEAPCtbicIQomaQTKTp/kbpT1ggSx+2JJ28kqec0XRujVmEt" +
                                        "Ln7O09QkdaXo40mKxazRxQ/r9FOOHm7T46K1VINZrd+lS29RPk9XR/lZDfmH6OsVur9F+S16sW+N" +
                                        "1QxlaGaWnhbpqxU6lab+Pms3IHxuSiU1PlYiatyOkLqZVX+Xx7muejXVnlDPdu2Aap7tllqF9Xn7" +
                                        "kjVWs7cHu3Mfz6byW+x5po/PMbGGFHeMs19TbTH15x57/rihRkbVzKweVsEr+66+L2/fwVFcyNDA" +
                                        "IHUkjLmGhwUkgkQuwO1mlqamcSJbWrg7kXW/IgOSa25W7u/zbZHXLs6fld+vi1gMDuiJ3Aadqb2J" +
                                        "dsBRvHOFL70aN+YKL79il0Lfm/JezpmVLweSUq/LJ0WsBoE8xcqoXxbHEvbrYy0iPZGq47UZbaJY" +
                                        "IbdhAz+/YC0BTE2zM3Lwwe/o2YFLi+aiB7e0vxBOwlpWlu3Y7+6qCxk+6UzW+Hy6UHFoSJPZNzLK" +
                                        "bvG4KvDkD0dd+D7QN+3vs92GnEqz/wTPFSd8HhA+J0xYiQ44b4uxcSjD3eKOWcWItb6s6dVPefeK" +
                                        "7QbTZPhi+qEBs22Cup13c4s/sWabxKzTX/O6Ewiq7/wCjqIzWbMzXL8hX+xj2dI8VwxqT4iPJnGU" +
                                        "t6Z5iAG1AjQ/q4Y8KZoqIS8Po+b4NTp2lLSbH3Xhk5I/hc/mWA8qDtjb050yz59T+jRvxFVNvnZc" +
                                        "ooIAbGQO93Lyi8/5BMZ4uZyNZ0VXkmvT9RvGIP/rrBpyEBSUCnN3fDWApi58Pbr63t/WnSbYzPEn" +
                                        "glUNAvHtGiqxfFp0Guqu6EiIb1bpXDmJEJTLwziKXi0I4GPaH0X6UCcgbmJ2JyQsQPH+v4A80i9D" +
                                        "LC2K4o5fY9USjF3EDkuLqAi8G2xqERDM2io74ybrXNHtuVNN/iqpgUFrvDZmFUA1Rh5hJ0HxHuId" +
                                        "o76pjgQLqYksd1uFerxjxwbQZO3r127dKZ7nYfESLnrjhzYW41nKXKQ2r+yFwlxZlrc/4ZzCK0JO" +
                                        "IVmMcFlaJGgLA3b694blZ7w8xcgo1z5IbsNv27LnJA83CgPrHXLELNIyEmloHJCMPSflowKXSDjD" +
                                        "0097x4/S4FkWLtAiUM4BoCJgAgeSCwWqbTpt7fW0e0k3g4liDZC1ej9tpuFVO2llLfV7mdE3uIQN" +
                                        "3bxqiJLuFFtcAsWFSTqkJ5IO2qgzae7j11iTI1UDlbBp/Fx4YtHoTT+gqXODdjJeeIUP4CtBN+Ab" +
                                        "ln8JuBvWUW9azdWocHPJWwp8uYyCwFcxb2j9mVnrHFwioGnicXYb0N8BoYdCOpFCQM1wVzM1BIrV" +
                                        "PCugQd6yJ9jdZT3U5f1iIG68fyOV8f/NG9EE0T8uoYjCF4oofKGIwheKKHyhiMIXiih8ISD6F/5k" +
                                        "lmAVXV+9AAAAAElFTkSuQmCC";

        const string VodafoneImageString = 
                                           "iVBORw0KGgoAAAANSUhEUgAAAFUAAAAcCAYAAAAQovP+AAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                           "jwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAATBSURBVGhD7ZdPaB5FGMbfSoS30MMGLCSgh4CC" +
                                           "EQpGLDTBHir0kJYK+UoKNjRQqx78c2jtqa09hOIh1ArFeqhWQagFS1OwaA9Ccyg0B8UUWhohQgoG" +
                                           "GrCQPRScg6DP8+7MdvI535cEskRhf2SYze7s7DvPvH/m2/A3kJo15Qnf16whtagVUItaAbWoFVCL" +
                                           "WgG1qBVQi1oB639OvfaDODSi5z+1fkU4J+4q3pu8IW7hgaiq6LcX/cP1Zd09lYK4n36xthrcJ+fE" +
                                           "jZ8u3vsdc8zO+Sfrz/82/N2PN6zX7QOSXZ+Q7NIF+/+/QDr8J6dEHi0W14O7RDqKSyM84z0+C9ye" +
                                           "ETczY8+0q1tk60siXV3+YUSei9y8ZR5qwMOCQNn0LeuNv9BuTombhwe6P6HeRsyL+ThvlkneN2DD" +
                                           "dM9u0a19Ips7Rbb12z2D9szCnryFPZz/Vzyfw/eDLZs6RZ/rEXkZ88U8Qqq5jlQzj3FMM1teEHkl" +
                                           "+lYTSVEttL4u8lM2fkpk56t2TUHynRASBumOAdEzp+2eO3lKHIRaguLvjUOibx3yNzDv5QlxZ8/B" +
                                           "SIiUoBT152lxY5gTYZ2C44KoAYVolpNXaE/+2l5LGykomp7F2rB5cnta8mMnRB54J/OU60+QDH89" +
                                           "OFJ6ZygixAoDdxjofowB5QIwXkdHJDt5wkJSHP4+Q0jyHXIXnoMcSEG1t0f02FHRI+/Z9RLmFyQ/" +
                                           "fLQQdBO8s7FbsjHMSU9LoH0QAN4q/YXIsaBmD99N2ePRZ7ptnDVcE3fnnriPaKsrBdUejKO9b2NT" +
                                           "OjvFTSLaPk+nnHROxQ7pIAwFbgoGPkTIkmtXrCtD5P7C4wVgvB5+V2RoV7HL+DBxlwqPN88PGzL+" +
                                           "sehwQ/TAfpEdPgo87jwMpSdD0OzyRdEPj4vsQXQwxBPoEOYZOw5HwFyxPYguswfvpuwpeREejnHW" +
                                           "vrtSbrKbQprj2r2H6vtwAs45hHW+3rB7wpSQoGWh0lEYSSCEuwoxmaPmfLgMI3TI7L2iB7p9aY5R" +
                                           "n5fKqny/6G1Dnk7k2sDd4hSgvb3pnNyOyB7LoRH/sqcV3uO5sc7bTPIjH0g+2LBmHg9KPZpoXf2f" +
                                           "RYj2e8PsLDlRXDMk4R3G5iJcSGyAsbBQ9N5DhMUCOBaqdnQg+QH32zKLTxHZI6H4BJrtaQUKUQkK" +
                                           "V8DSwzvIyU0tRdsjFScizG9u4nu71gYEDacBCF8ayQoeBKNXIy8R3ebDts9v0B+LVgjLsc08j8pK" +
                                           "FjEOha3kDir1ckT22IminT0rQLcgWgKsGShyS9rBtKgbkkeqCLdv5HHIYOKMHhuHJYy3ZM58yU3m" +
                                           "okKlxDEn+wY57ClUUeBG3ywXZxvTDc9axML9acCqPzwqH8ZmhhMCIsMI/4O4+rMQWc4NNNtD7w1V" +
                                           "PrInVH87kiEnB1h8QnjzO/FJyKKUaYngqCYZjmCJX4FtPZXogcJbiVXR5jyH5J19daFIFR0QgIKy" +
                                           "ou7bKxl/NnpBiX75RRE2vsqGxVplDTkQ81uBYkXnBkFM7e6yyst5rbUjtmcj3uc3WtizEljAsjMo" +
                                           "rLTvSS1+/fE8znNzfE6PWNZTa1bPsp5as3pqUSugFrUCalEroBa1AmpRK6AWdc0R+QewC/0/WsQf" +
                                           "4gAAAABJRU5ErkJggg==";

        const string SettingsImageString =
                    "iVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAIAAACQKrqGAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                    "jwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAD3SURBVChTjZE9CsJAEIU9kh7BgE3AwoCFAQsJ" +
                    "FhIsJFhIsJGUwUJyAiEXEFLGMh5AiF0sU1hsYZHCYn2bWXejCPp4xfx8DDO7Lf63NFpVlTt37bGN" +
                    "AKkzdbyFRzFJo2VZdtod2OgaRs+gWPZqCZQxBi7aRdRuOjkkAKq7mC1Qd+aqHuL0mMLe0lNFa2BJ" +
                    "FGspDqmSv/Y/Uf7gSFDCMJG+lJ9zFLG6XgDC4V/Qi0BpJPS2gL/yqUpSh+LVkNboRKJwsAkwDG4+" +
                    "iNk3JcpuDL1wG6qecryP8ZQAJErKThm1m19AEEmjxbXAcTiC7rVHtjWUMUmjP8T5E2XJlrsosnjm" +
                    "AAAAAElFTkSuQmCC";

        const string StockAnalysisImageString =
                    "iVBORw0KGgoAAAANSUhEUgAAALQAAAAoCAIAAADYC0ddAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                    "jwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAzvSURBVHhe7ZoJWBRHFsdfzQzDDIeAiIRLEQMI" +
                    "KCCCCipyeB9oPPBaxYtovJIY47E51CQm6+dqjCZmEzTGKFFRVFDEiAGFeIEBUQyHIiCXiJwDw8Ac" +
                    "tdXTHRjmADT7fRuS/n39NVWvamrorn+996qnkUgkAhYWbXCYvywsGrDiYNEJKw4WnbxkznE380H8" +
                    "pcQ7dzILCosbRA08PZ6VlaWHu+vUyWP9/YdzuVymH0t35oXFkXE36+NPPs/Ny584IcjP19vBoa+Z" +
                    "qUljo7iktPzOr5kxsT/1MDb68IP1o0YOYz7A0m15AXGIRA0fffL5xfifl4TNeWNlmKGhAdOggkwm" +
                    "j/wxetfur0mHVSvDEEJMA0s3pKviuJZ8c8s/P+3f337nv963trKkjfb9hxbmp9JlVR7lFy5Z9raP" +
                    "t8eunR+wIab7oi6OqFPnp04ZKxQKmDpAdU0tiSPxl5I2b1wTtmg27QyILOhWGk2JVFRUhs5bMWzo" +
                    "4J2fvc/6j26KujgWhq0tLCqZPCmYuAcyqSTxJHHEe4jH9q0bSHrBdGrvM3SVS8uezgpdPmXS2Pf+" +
                    "+SZtYeleqIuDJA0JV64lXb1eVlZhYCAkgpg8MXjQIBem+Xe6Ig5CUVHJjNnLpodMIPrgcNhtczfj" +
                    "BRLSjgVBznSVprW1sLB48bK3LC0tVoYv9PB062lmSttZ/vz8L1czEQR9MHUl9vZ2588d8Ro86MNt" +
                    "u2aFhjNWlu5AlzyHplfQ6jnULHSZpfvSVc+Rvd+EPpi6UgH0wdRZ/nK8ZFghjoH2Da0Flr8eOsOK" +
                    "Wpho9Rkua+uijn+DMSY5ZkDwTNU+WssvgOwZP+NTvaJzqLmKqvLsFU5XxIMfGERO0yZhH3lgYpM1" +
                    "VULlSYIHu7lVN0HWAsgcm74uH7xeYtX2qIaCDH7voN6T71FjOVXlWmGLfZLgCfKyCMOk9cgypmFM" +
                    "kLKfVO/meP3HaWAZIx4TpFCa1ClGG2MhVw5+fnijN7Q9w8lBYZehFmDKOLx8QJu9+AbacAdch+Kt" +
                    "wxkLRYeDGDjjPeNByJggPwVtzgB+H/hyGjaju8oh6gSKrIY5U/F8e2h+ik6kwNVKqJZRjcbGsDIU" +
                    "982kvlei7O5Ff3sLpCSj6AIoagJyaXp8CPLFqzyUPbTxAp4j+YFs7u4GUgidt2LO/JVEGdZWlnu/" +
                    "iBCLm+gOf4xq/auj+Hnx2CFBPEfUsKBS4rkOMPm6IPECUiXHXbkR6RYuZaqMMjgPNhkmhXCl06TB" +
                    "pcTeOD1BLjjPS/QwyCylmmnqbxicd+Hn/YQdYsWzyGerxUFHFHoNmhdPRqOUYbynOUCHMshUFUKB" +
                    "HHgcuP0IlcoZoyoXbqD0Rqasi04HUaX/EBhrBA3FEF/EWCoyUGwVmPeDyX1BVoo+OwsxjbAoBJ9d" +
                    "h6OX49etoFkBdn74395AlgijDDmcP4d2Z4PjEPzDGhyzGu8aDkIpM6BWtIiDrHtyqBYIm482rfhP" +
                    "Y2Zhu+soK6/Yuy9i/KT5eQ8fMyYNWkfohOrLvIoyMN8l8XJU8EhdIHMOF3v1pxt1Uh8rzDwARnua" +
                    "x4Y396JcBTZwlATFyXo3cx68JaikO5UKUqZymrzlI6+I3Qco9IlFT9Hbt8l/ltqdQSURwswI4IdL" +
                    "A8Kl1P+gDTmkPIKWXrDADuSVcOc5Y27FzBAEDXAwBUSYsWihs0HUMcATB4AAw5UsVEeGlUP8fRDx" +
                    "YPZQbIIgJwfuSSFwCA60paaTZwD+E3CwMfPRNgpRfAWY9oMwLzAm/bjQzxMv8WYataJFHATV9JNE" +
                    "EHKOSW0hZx9H/levU7+3BQaOuHj+2PKl8/l8fnFx6dz5bxDjH0Jf+TOeOI+ndIxdRO+3vQibK5wX" +
                    "t5/LnpK+SwFf4ubeo2p5h3i1LbjvniZbPWWrDuoThTfXI/CT++5s7sHYNJHloWsicLHDwf3AFENS" +
                    "FjQzLQxCW1hkC+V56EQu6JJHp4NoYucJwUZQVQA/l0PxbRQvAuv+OKA31cTnUbNYVgud3DkeCBHU" +
                    "i+B5l++wdnGoEhP7E11YMU7/yFph0CDqFiNArq5O77/3VtSJb4yNjaqra+g+qmj1QDoxnCi1s4em" +
                    "7fxzMwzuPeR06QLqubVpRKgKzVm38SQTg+p+4xIBVV0BMMcWbkyTVnCu8OpsjtRe4XG8Yw2l5kMN" +
                    "guFOYPIqeAugsAQ9plaNKjhoNAzndxRcujCIBr87jwtp6HgWSPgQ6sskJU4DYZgAfstAa6JRcgmV" +
                    "TGinL55sC7gSNvyAfrwLIp392uhcHF/sP0jOo914b04RaP6C5unhtmvnB3SZFoGqDlQ9UGfotfin" +
                    "SQatw7IEzn0vg9OjDbKfaXybGpWIWnFm2JCuqmBoRK1amYhcHqcxA8ABU/mKbuoOcEUtYLhK6tyT" +
                    "sWilCiUVA8cCvHtRs+Xbh+gPkh4yjW2YU+7auAEO/6ItuHRxEA0Y51EE1yXg6oZHtbo3c/x2KF5i" +
                    "B9WlsPsMWnIc3alnWtQImoq3eYFFE5xMRmEHUWS2biUp6VwcBQVPyHnVRC3KoJkwPtDZiUoOSJQh" +
                    "Z7JPeZmtCoVA5r6j8bXcFpd1GNI56aOED6qZFu0YYSqa1CDNBSpTeh59S5IiYT1zktF04rhNd0it" +
                    "rKFho/7VxA7uSEU+ZEnB1RZbKV9D8OwLZsQNFCAqS2+PpTdebAsleShKI7h0fRB1aOdBCkII8SRR" +
                    "og2eKUx/DX83E+bZQlMlfHpGh9PigsdIvH8J3uwOllKIuoIO5+iMfYTOxUEwEqBBfTp6LcPPj0ps" +
                    "cvPy6eofQt+6xWtH46RIjMo4D092mCZYyk0HACRxSjRy7se3yIVhUzeyMmQmgWRzwHmusnnRglGz" +
                    "f6zcmA8Vs4W3cnV5rF8eghjgfjqasQ9N24dmJhDRQc0TuF3HdFBlDAkuehB3C2W3/+9eaBA17BzA" +
                    "mYjCFFw0801yDTZ47gz8sQdw6yEmU+esk4zVNwDvnwJOHIjNRFW61dFVcXT8SoaJCeXjGhoaX9Zn" +
                    "kIQqUaA6xz3sqW2FvLHjyCJ1egejKs6j6PZ7i2rB4y8AzZK7Uv5MMXClgg+ocLe+DmfLwHNuCjil" +
                    "4Leg/BDtHqsI3agBbm/4ajWOWcccH7kAVwbXs7XNhDK4GNTD0Vxou7AXHaQLZKWjJyopmo0pkDvX" +
                    "LNcIGfmIJLOt8CzAhqx3OUh0h5YuieNprcJlbV3rwVh/RyRqyM6mYmavXh0F7IiDx8aMC2UqWsjn" +
                    "JvszqWhzDf/mu1wJH9tM1fAJ7bGY2+QRDrWrBQln9ETU8x4kyhEkTuZVWys8dkvoqMwb1uS7B0sj" +
                    "9C6vET4uVqa6Es6TJGHyaXW31COI6kk8VuY8oYY3ysyDAkVbOKBxswdLBHcLtT+roINLg4RMAcNL" +
                    "DNIpzc9gSxS6pkxFG56hY+kg4sNoRxJD2iOFH2LQ4QwqFZWJIeUapLSAjwN+RXdI6Fwc9HsYAwcO" +
                    "CAoc2XoQy7cRx8ZPnDfAzd/LZ1zClWRiSU3LWL9hW/SZuNKyp9QnlSgw3HlETcip0xe+PrCTNmqh" +
                    "93i5rR3K8Tc4aWx02pVfYaIYlCYe7tzpYlK47WkMOqaQ7tWPszCKNDaMC+FKpsoC08RubUrFtuHi" +
                    "iYly00Jumic1fqSNQepWDs9Ocy6w7eIWBz/AN7g3N7XzNGKUXAByBCMGtrvpPEfsZwTyZ5BEJWZa" +
                    "oIILnyl3fZCyXDRXGXSo4zt0t8OE6VVHGI4gIga9tg8tiobcHrBxGp7wCvNklqyY9FS0/RZxKTjU" +
                    "Fm7eRgu/RDMPoUPPYWYAfmdYu9xFDS2Pz8l2o3V/QfxEYIBf0tUbffrYxMUeJbtWYkzPuL9qzZa6" +
                    "uvo+djbm5mZGRoaXE67xeNzDh/YWFhbfuv3rrdvpRFKVlVUe9tyiSoW5Mcp/qsjLuc7X6zCFYPmT" +
                    "0bk44uMip01f3CKVuru7Hvjys/T0exve/Yhoxa6PzUBXZ+Ikzpy9SHp6D/E4dfLb1tyE2EeMCjnx" +
                    "jpF1T45FD0TGefl0hOX/ROfiIJN6OvrCu5s+xhiTpa/ACi8vd6tXLPl8PeIhiovbdgGLFs7evnVD" +
                    "qz5UH3gQWHF0O7SLgykpoSf1Ynzilvd21NWpdybhw9KyV3n5M7q6OCx024cb6DINGY2VRTdFS0JK" +
                    "5pKeztYCwcGhDwI0LWTCsGFeJM8gh6ur0/Kl8+POH70Ud5ykq3S3749EpaZm0GWW7k6X3ufIzctf" +
                    "GLZ23Zpl/1gwk7aoQTzKgkWrs7JyuFzuxQvH6AemLN0ddXEEBM8MGO0bMHqEq4ujmZlpfb3ozNm4" +
                    "A18f2bRx9dw505lO2hCLm8gmdoDzqz4+noyJpZujLg6SPZw8FXP9RlpZ6dPqmlqSdQ71Gbxm9VIP" +
                    "d1emB8vfBp1hhYWlS4/PWf6esOJg0QkrDhadsOJg0QHAfwHl19lkwdQ+ogAAAABJRU5ErkJggg==";

        const string CheckMarkString =
                                      "iVBORw0KGgoAAAANSUhEUgAAABgAAAAXCAIAAACeQxh6AAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                      "jwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAEFSURBVDhPY/j27dufP3/+UwCA2oGGMEB5FINR" +
                                      "gwgDcgz69PvbnAe797y6COWDAckGHX1zPeHcJOMDxUB09O11qCipBiGbYnmo/Mz7O1AJTINufn56" +
                                      "/sM9KAcVvPn1KfhUJ8QUIOq9sxEqAQYoBq17egKiqOfOho+/v0FFwQDZLUA08/5OqAQMoBi08skR" +
                                      "uNKyKwv//PsLEcfvFghAMejr7x/IGiBmEWMKEKCHEZq24ivziTEFCNANAoJrnx7nX5oD1wxHmOGC" +
                                      "DLAYBARXPz3OQzULvylAgN0gILjy6VHupdlEmgIEOA0CAmBWWPPsGFpWwAXwGUQSGM4G/fr1C8qk" +
                                      "APz+/RsAv94Khm9AE7oAAAAASUVORK5CYII=";

        const string CancelMarkString =
                                       "iVBORw0KGgoAAAANSUhEUgAAABgAAAAXCAYAAAARIY8tAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                                       "jwv8YQUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAHMSURBVEhLtZRLL0NREMf/1bQhXukCW7EQn0Di" +
                                       "A0iDUhFvFggS38CKROIT2AhCIhFpKh6xsbAXmlpI6lVdYcGmGy25bcOZnGncxzll0ftLms7MvZn/" +
                                       "uXNmxpPNZr/9fj+8Xi/KSaFQgGEY8HwLOOYKFfzvGq4LqEv09g4cnQANjUB3EKiq5Ac2Mhng7BzI" +
                                       "GfK9ujp+8ItT4PMLWFkFbhLS72gHxkeBlmbpF4ldA/sR4CEp/XAImJ+RtglniURH4fmVHcHFFbC+" +
                                       "IYWLpNPA1s5vcuL2jg0rTgGvCNFpzCTugeUVKULJF5eAF9MhiL4eNqzo23RTnPD4lB2mrRX4EHW3" +
                                       "J5+bBvp72bGiF8jlgD1R4+ghBxTUVANjw9rkhL5NfT5gYgQYGuCAjX8kJ0rPAYmERW0pmR1qyWAn" +
                                       "O3pKr4qruGzFxycO2NC1sAm9wGVMJI8CSU3yIn+IqEtErbi960yu6hbVnJhQC6ytW1uxvhZYmJXJ" +
                                       "pyadF09zEjlgx4paIJVigxkeBELd0qaLJxH7l8TF6lCgFugSi4ugZLohojh9CU0+/TQdpb9k2qh+" +
                                       "IRAIcEAD3ZchhrJJbF4Fpdu0DKhLVEbcF8jRUnOJfD6PH29EoyRaKj8qAAAAAElFTkSuQmCC";

        const string C1LogoString =
                                   "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAABGdBTUEAALGeYUxB9wAAACBjSFJN" +
                                   "AACHEAAAjBIAAP1NAACBPgAAWesAARIPAAA85gAAGc66ySIyAAABK2lDQ1BQaG90b3Nob3AgSUND" +
                                   "IHByb2ZpbGUAACjPY2BgMnB0cXJlEmBgyM0rKQpyd1KIiIxSYD/PwMbAzAAGicnFBY4BAT4gdl5+" +
                                   "XioDBvh2jYERRF/WBZnFQBrgSi4oKgHSf4DYKCW1OJmBgdEAyM4uLykAijPOAbJFkrLB7A0gdlFI" +
                                   "kDOQfQTI5kuHsK+A2EkQ9hMQuwjoCSD7C0h9OpjNxAE2B8KWAbFLUitA9jI45xdUFmWmZ5QoGFpa" +
                                   "Wio4puQnpSoEVxaXpOYWK3jmJecXFeQXJZakpgDVQtwHBoIQhaAQ0wBqtNBkoDIAxQOE9TkQHL6M" +
                                   "YmcQYgiQXFpUBmUyMhkT5iPMmCPBwOC/lIGB5Q9CzKSXgWGBDgMD/1SEmJohA4OAPgPDvjkAwMZP" +
                                   "/eeaqagAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAlYSURBVHhe7ZoLUJTXFcf/wC67y/JeQJCXBJEQ" +
                                   "ND6CKY5JbTASJPiMWm01idqHndhaYzp2TK1tTBzTsU1CZhpifIGmWh/VJiaFmFgTNYYajNH6IqhR" +
                                   "kDfCurx22V16z+VSJbC73y7fIjP4c2S55358e++5555z7vk+j3YGBjCe4nPAck8B4nPAck8B4nPA" +
                                   "cleiQHN1Lb78459RV3QW9PW6UclI+f3z0EaGiyv6jj5XwOGnl+Hi9p3QhoXDU6lgEg9Y29rQVF2J" +
                                   "hDkzMenvOR0X9hF9poD/vrkFx5athloXBKXWR0i7Ym5uQXNNDVLX/w6jVy4VUvfidgVUfVGE/OmL" +
                                   "0NbYxCfv4eEhenqGhmOq13PrSP/HZgyeME70uAe3KcBkaEL+1GdQfuQEtFHM3L28RI802i0WNN2o" +
                                   "RFjqGGR+sAOqoADRIy9uiQLHn/8DNvvHo+HCN/CLjXR68oQH+xvfmEgYrpZic/BQHF36ouiRF1kt" +
                                   "oGTnARz56QvwUirh7e/L7m7f3J2hzdDIrerRnPVIWjRPSHuPLApouHSZ7fOFbLWuQxMWAg9P96QX" +
                                   "7dZ2tNbW8e+YfDAPwcPvFz2u0ysF0IAO/fBnuLz3ffgOjmCOSyl63IvVbEbjjQoMyUpH+t534KXy" +
                                   "Fj3O4/JSFb38OjYqo1Dx6Rfwj43ps8kTngoF+85oVP/nK7yjHoKTazaIHudx2gLKPv6MrfoSvgqq" +
                                   "wACHYc3d0PBNDbe400zLfR2xU9JFjzQkK6Cd/dufOgU1J09DO3gQ/8L+BIXN5soaBI9IxIzCD7kj" +
                                   "loJkBWzyS4DSRw2FRiMkrmNlg7UYTbC2GmFhaTDLhhnsBxuKKtCf7WkVv84VzC2tsLD7LtJfEhL7" +
                                   "SFLAqVfewNcb3oJ3gL+QOA99DQ3MpDdAFRzATTV8/FgEPTAMSl9txzVWKwpXrUdN4aleOTb6jvi5" +
                                   "U/H9t14VEttIUsC+hzPRXF7FnI9rZk+r3Vp7E9GZaUhZswKhY0aInu6cWPESLuXt5ucFGprVZOIO" +
                                   "1pnQStuBLOHZ2nNCYhtJd22prGZ73vmAQROgiWvCQzGv5HNM/uc2u5MnLm7bBYVazf/WyJxbWOpD" +
                                   "aGtq5tYjGeaYrWaLaNhH2qzYDZ319jSB5vJKjFz5HGZ/dYilxFGixzb6b67CzCZLym4sLcfs04eQ" +
                                   "sX8LFtadhzpUx0+LkuBjlTZeSQpwdfLpbPApq5cLqWMu7znInay1zcyyvGHwj4sRPcCcs4fR7sTK" +
                                   "SsV5u3YATZ5OcU8wcx+SNUlIpVGy6wAULNKQucdNzxTS28w+VcAywBuiJQ+yK4D2fOqrqxCbOVFI" +
                                   "pGFmk6YzBTk8Y4MeCQueEj230UZGIHH+bO7g5EJWBViMRgQ/mISRK34hJNL5dv+/4OWt5KGQwm1g" +
                                   "wn2ipyvfW78KrTW1otV7ZFMA9/h19Xhi32YhkU79xRJ8vnwNT63J/IdMtb11yAo0EeE81MmBbAqg" +
                                   "gccws6c0WQqlBf/G/nFZyA0fiT0jH++I9cz7U8iLnztNXNUzgyekwmJiGaQMyKYA0y0DRrOQJ4Uj" +
                                   "i5bjg8nzYfi2jOfs2ogwPnmyItrfMRlp4sqe8Y+P7V8WQPvWS63CoHEpQmKbs9lbULxjH/xiInm6" +
                                   "e2eCZWWrGvnYeNGyjbefL69FyIEsCqC4rRuZLFr2KXr5NWgGhYpWV2j175v1pGjZhnJ9D0/nchNb" +
                                   "yKMAsxkhoxwrgI6rbXp2dreR1xv1DUiY3z38fRf9lWvMcuQ5jsuiADBzVPr7iYZtVMGBAA28B+sl" +
                                   "JQYlDuPm7YjKY4XwZCFTDuRRALNGmoAjKM7Hz8riic534eFvmuNqTuvNejSWlbtUau8JWRRA5th4" +
                                   "rUy07JOWlw3dg/ezzK9rNkcnPynmf/pPf4VGpxOt3iOLAsgcK44WipZjphzeizZDEw97BEURpb8v" +
                                   "dCOSeNseX2/IgcLGs0VXkMcCmFNrra5jh6AKIbGPl7c3Iic+AqvRxNtUMIlOn8B/t8dnS1bykpmc" +
                                   "hVh5FMAGpPT1wal1bwqJYwaljumoBzIo+xs6dzr/3RZ1Zy7g3Nu5/y+fyYU8TpBBZnlh07u8RC0F" +
                                   "Dy8Fjwa0DSws/sdNzxA93SF/sS8lA37RjosqziKbAsgK1CzMvZc2S0js01h6g2eB9HLEoHEPCWl3" +
                                   "6JicFzEamlCdWx65SbujcFaOoHL2rSvXUTBzsZDYprTgCE+FLS1GxD2VJaRduXm+GFuDkng5vuNt" +
                                   "EvmRpAAr89JSlUBOquzjo3h/4mwh6Q5lhE2lLJYrFGil4sePZ4ie2xT+9hXsHpHGVj7Y+cdufKzS" +
                                   "xitJAZowXYcSJEJboe7sRWwJTMTFrbuE9DZXD+Tz1af6XvDwRPiEhYge4PzbO7AtJBnncrbDNyrC" +
                                   "ZbOXelaQdPeYzMelV2QFSh8NvFl6fPxXq7E1+AEcXboKZZ8c4x6/OHc3c5paPkh6OkS1wI/m/Byb" +
                                   "tPE48ZuXoNCoexXuaKwxEuuRkh+NbVTFspUNcumJDSU6dNLrVCIppvM+1Ee1BPIf9L+3pzzKKYz1" +
                                   "DVjcfBmeno7TZcn2Rc/avLQaNFfV8EE7A5kxPekhT64OCe6iROqjUhitem8mT2Nqqa6Fl9obC0qL" +
                                   "YLRIu5dkC+ikePtenpHRann7saRExqzMVUyGRm5d499Yi7iFPxJS5ruUjtfXaQV0cnzZapzJ3gRt" +
                                   "eBhXxt2AzL2pshLJS57F2Ox1QnobtyqAMNbrkT9jESo+pVfhImQ7ojqCv0JXUYWwsaOQ8V4uEBgk" +
                                   "erridgV0Unn8JApm/QTmxiaomKOU87ByJzRUUrqnSolJO3Ogm2C/fthnCujkzGsbWRhby19qtPU6" +
                                   "rKvQHm+pqcXD61Yh6QVp1ec+V0Annyz4JYp37IE2IoJXgXoDFVwN5WUYOms6Hv2bcy9S3zUFEIZr" +
                                   "pcifthD1LJ/3YY7S2YyuI6zVQRsdgayPdkEZ5fxJ8K4qoBNKew8vWMqPv6oAP/aNjv0DJUbmlhb8" +
                                   "YFs2omb2fFCSghQFOLcsLkDn/MWGEiQ/9wz01693qwXeCRVG9deuInHxPMy/daVXk5eK2y3gTmg/" +
                                   "fzjlaf5ckPKHzlMeyZsqqxD12CPIOJgHs1KevKJfbIGeqL9QgqK1f0HNl2cotiFkzHCMefHX8ElK" +
                                   "FFfIQ79VQH/C7T6gv3NPAeJzwHJPAeJzgAL8D/AdwY49vQm0AAAAAElFTkSuQmCC";

        const string C1LogoIconString = 
                                       "AAABAAQAEBAAAAEAIABoBAAARgAAABgYAAABACAAiAkAAK4EAAAgIAAAAQAgAKgQAAA2DgAAMDAA" +
                                       "AAEAIACoJQAA3h4AACgAAAAQAAAAIAAAAAEAIAAAAAAAQAQAAAAAAAAAAAAAAAAAAAAAAAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcBIMxnAyzMZwOszGcB1MxnABjMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwCQzGcCyMxnA/zMZwP8zGcD/MxnA/zMZwNszGcBRMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAEDMZwIw0GsD6MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwL8zGcAxMxnAADMZwAAzGcAAMxnAUjMZwOszGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/TMZwJEzGcADMxnAADMZwPEzGcD/MxnA/zMZwP95atv/19L2/4V23/+N" +
                                       "f+L/p53q/0Epxv8zGcD/MxnA/zMZwP8zGcD/MxnARzMZwAAzGcD/MxnA/zMZwP+Acd7/////////" +
                                       "//+7s/D/aVfV///////o5vr/Uj3N/zMZwP8zGcD/MxnA/zMZwFozGcAAMxnA/zMZwP8zGcD/4+D5" +
                                       "////////////n5Po/zcewv/z8v3//////9bR9v80GsD/MxnA/zMZwP8zGcBaMxnAADMZwP8zGcD/" +
                                       "MxnA//38////////8vD9/zkgwv8zGcD/urHv////////////XUvR/zMZwP8zGcD/MxnAWjMZwAAz" +
                                       "GcD/MxnA/zMZwP/j3/r///////v7/v9ZRc//MxnA/35u3f///////////3lq2/8zGcD/MxnA/zMZ" +
                                       "wFozGcAAMxnA/zMZwP8zGcD/kILj////////////+fj+/7y08P9DLMf//fz///////9bR9D/MxnA" +
                                       "/zMZwP8zGcBaMxnAADMZwP8zGcD/MxnA/zUcwf+6se//////////////////YE3S/83G8/++tvD/" +
                                       "MxnA/zMZwP8zGcD/MxnAWjMZwAAzGcDxMxnA/zMZwP8zGcD/NBrA/35t3f/PyvX/8u/9/5GD4/9E" +
                                       "Lcf/Nx7C/zMZwP8zGcD/MxnA/zMZwEMzGcAAMxnAUzMZwOszGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/TMZwJEzGcADMxnAADMZwAAzGcAQMxnAjDMZwPkzGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnAvzMZwDEzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAn" +
                                       "MxnAtzMZwP8zGcD/MxnA/zMZwP8zGcDbMxnAUTMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcBIMxnAzDMZwO0zGcB7MxnACTMZwAAzGcAAMxnAADMZwAAzGcAA/B////AP" +
                                       "///AA///gAD//4AA//+AAP//gAD//4AA//+AAP//gAD//4AA//+AAP//gAD//8AD///wD////B//" +
                                       "/ygAAAAYAAAAMAAAAAEAIAAAAAAAYAkAAAAAAAAAAAAAAAAAAAAAAAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcABMxnAWTMZwNQzGcDzMxnAmzMZwBkzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wDEzGcDCMxnA/zMZwP8zGcD/MxnA/zMZwPMzGcB7MxnACTMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAZMxnAnTMZwP0zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA4TMZwFEzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnABjMZwHozGcDzMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcC/MxnAMTMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcBRMxnA2zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/TMZwJ0zGcAY" +
                                       "MxnAADMZwAAzGcAAMxnABjMZwLIzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDvMxnASjMZwAAzGcAAMxnAYDMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/1pG0P+4sO//5OH6/0Aoxf9sW9b/tq7u/2NQ0/8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA4DMZwAAzGcAAMxnAhjMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "iXrh//z7/////////////3dn2v9LNcr//v7///////+5se//PSXE/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwAAzGcAAMxnAhzMZwP8zGcD/MxnA/zMZwP9pVtb//fz//////////////////5yQ" +
                                       "5v8zGcD/2NT3////////////0cz1/zoiw/8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnA" +
                                       "hzMZwP8zGcD/MxnA/zMZwP/MxfT//////////////////////4Z44P8zGcD/npLn////////////" +
                                       "/////6ie6v8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnAhzMZwP8zGcD/MxnA/zQawP/6" +
                                       "+v7/////////////////1tH2/zoiw/8zGcD/YE3S//////////////////v7/v9HMcn/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwAAzGcAAMxnAhzMZwP8zGcD/MxnA/zkgwv//////////////////////fm7d" +
                                       "/zMZwP8zGcD/NBrA/+vp+/////////////////+Fd9//MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAA" +
                                       "MxnAhzMZwP8zGcD/MxnA/zMZwP/n5fr/////////////////pJnp/zMZwP8zGcD/MxnA/7Kp7f//" +
                                       "//////////////+glef/MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnAhzMZwP8zGcD/MxnA/zMZ" +
                                       "wP+lmur//////////////////fz//5qO5v9RPMz/MxnA/3Rk2v////////////////+VieT/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnAhzMZwP8zGcD/MxnA/zMZwP9FLsj/8u/9////////////" +
                                       "////////////////gXPe/zoiw//49/7///////////9gTdL/MxnA/zMZwP8zGcD/MxnA/zMZwAAz" +
                                       "GcAAMxnAhzMZwP8zGcD/MxnA/zMZwP8zGcD/alnW//n5////////////////////////ysPz/zMZ" +
                                       "wP/GvvL//////8a+8v8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnAhjMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/2NQ0//k4fr/////////////////+/v+/0Aoxf9sW9b/vrbw/0Aoxf8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwAAzGcAAMxnAYjMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP85" +
                                       "IcP/hXff/8a/8//p5/v/7+78/2ZU1f8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA4jMZ" +
                                       "wAAzGcAAMxnABjMZwLYzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDyMxnASzMZwAAzGcAAMxnAADMZwAAzGcBV" +
                                       "MxnA4TMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/TMZwJ0zGcAZMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnACTMZwHszGcDzMxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDEMxnAMTMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAZMxnAnjMZwP4zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA4TMZwFkzGcABMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwDgzGcDHMxnA/zMZwP8zGcD/MxnA/zMZwPMzGcB7MxnACTMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcABMxnAWTMZwNczGcD1MxnAojMZwBszGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAD/gf///wB///wAP//wAA//4AAD/4AAAf+AAAH/gAAB/4AAAf+AAAH/gAAB/4AAAf+A" +
                                       "AAH/gAAB/4AAAf+AAAH/gAAB/4AAAf+AAAH/4AAD//AAD//8AB///wB///+B//8oAAAAIAAAAEAA" +
                                       "AAABACAAAAAAAIAQAAAAAAAAAAAAAAAAAAAAAAAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAQzGcBpMxnA1jMZwPUzGcC6MxnAODMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcBAMxnAzjMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD+MxnApjMZwBwzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAkMxnArjMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA8zMZwHszGcAJMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAMMxnAijMZ" +
                                       "wPkzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwOEzGcBZMxnA" +
                                       "ATMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAC" +
                                       "MxnAYjMZwOYzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcDFMxnAMTMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAQDMZwM4zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD9MxnAnTMZwBkzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAHjMZwKkzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA8zMZ" +
                                       "wHszGcAIMxnAADMZwAAzGcAAMxnAADMZwDozGcDxMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwMozGcALMxnAADMZwAAzGcAAMxnAyzMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/RC3H/5SI5P/Qy/b/r6Xs/zMZwP9HMcn/ubHv/3pr3P83HsL/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwHczGcAAMxnAADMZwAAzGcD7MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/31s3P/y8fz////////////z8v3/Nx7C/zcewv/z8v3/" +
                                       "/////+fl+v91ZNr/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnApDMZwAAz" +
                                       "GcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP+IeuD//v7/////////////////////" +
                                       "//9mU9T/MxnA/7208P////////////////+nner/NBrA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcClMxnAADMZwAAzGcAAMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/UTzM//n5////////" +
                                       "/////////////////////4Bx3v8zGcD/fm7d//////////////////////+roOv/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwKUzGcAAMxnAADMZwAAzGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP+vp+z/////////////////////////////////alnW/zMZwP9CK8b//fz/////////////////" +
                                       "//////92Ztr/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnApTMZwAAzGcAAMxnAADMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/+rn+////////////////////////////9zY+P82HsH/MxnA/zMZwP/P" +
                                       "yvX//////////////////////+Xi+v82HsH/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcClMxnAADMZ" +
                                       "wAAzGcAAMxnA/zMZwP8zGcD/MxnA/zMZwP85IML////////////////////////////49/7/SzXK" +
                                       "/zMZwP8zGcD/MxnA/5KF4////////////////////////////3Fg2P8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwKUzGcAAMxnAADMZwAAzGcD/MxnA/zMZwP8zGcD/MxnA/zgfwv//////////////////" +
                                       "/////////9TP9v8zGcD/MxnA/zMZwP8zGcD/VUDO////////////////////////////q6Dr/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnApTMZwAAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/+fk+///////////////////////8O78/zkhw/8zGcD/MxnA/zMZwP8zGcD/4+D5////////////" +
                                       "///////////CuvH/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcClMxnAADMZwAAzGcAAMxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/r6Xs////////////////////////////t67u/zgfwv8zGcD/MxnA/zMZ" +
                                       "wP+mm+r//////////////////////8O78f8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwKUzGcAAMxnA" +
                                       "ADMZwAAzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP9ZRc///f3+////////////////////////////" +
                                       "5eL6/6ie6v9cSdD/MxnA/2lX1f//////////////////////pZrq/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnApTMZwAAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP+upOz/////////" +
                                       "//////////////////////////////Hv/P83HsL/Nx7C//Lx/P////////////////9oVdX/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcClMxnAADMZwAAzGcAAMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zsjxP/U0PX//////////////////////////////////////2pZ1v8zGcD/urHv////////" +
                                       "////zcf0/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwKUzGcAAMxnAADMZwAAzGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/0Aoxf/Kw/P/////////////////////////////////qp/r" +
                                       "/zMZwP94aNv//////+Th+v9KNcr/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnApTMZwAAzGcAA" +
                                       "MxnAADMZwPwzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zUcwf+NgOL/8u/9////////" +
                                       "///////////////k4fr/MxnA/zQawP9xYdn/RjDI/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcCkMxnAADMZwAAzGcAAMxnAyzMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP87I8T/g3Te/7y08P/g3fn/8O78/+Lf+P9AKMX/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwHgzGcAAMxnAADMZwAAzGcA8MxnA8zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDMMxnADDMZwAAzGcAAMxnAADMZwAAzGcAjMxnA" +
                                       "rjMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDzMxnAezMZwAgzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAQDMZwM4zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD+MxnApjMZwBkzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAzMZwGozGcDrMxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnAxzMZwDgz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wBAzGcCMMxnA+TMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "4zMZwFkzGcABMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAkMxnAsjMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA9jMZwIQzGcAMMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnASDMZwNUzGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/jMZwKYzGcAeMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnABDMZwGozGcDaMxnA+TMZwL4zGcA5MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAAP/4H///8Af//8AB//8AAH/8AAA/+AAAD+AAAAPAAAABwAAA" +
                                       "AcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAAB" +
                                       "wAAAAcAAAAHgAAAD+AAAD/wAAD//AAB//8AB///wB///+B//KAAAADAAAABgAAAAAQAgAAAAAACA" +
                                       "JQAAAAAAAAAAAAAAAAAAAAAAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwBAzGcCDMxnA" +
                                       "3DMZwPszGcDbMxnAgzMZwBAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcACMxnAYjMZwOkzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwOczGcBiMxnAAjMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwEAzGcDOMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnAzjMZwEAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAgMxnArjMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcCuMxnAHjMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnADDMZwIQzGcD2" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA9jMZwIQzGcAMMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAIzGcBiMxnA5jMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcDmMxnAYjMZwAIzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAODMZwMszGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwMkzGcA4MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwB4zGcCmMxnA/jMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD+MxnApjMZwB4zGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAJMxnAhDMZwPYz" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwPYzGcCCMxnACTMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAATMZwFkzGcDhMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA4TMZwFkzGcABMxnAADMZwAAzGcAAMxnA" +
                                       "AP///wAzGcAAMxnAADMZwAAzGcAmMxnAxjMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcDFMxnAJjMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwB0zGcDqMxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA6jMZwB0zGcAAMxnAAP///wAzGcAAMxnAADMZ" +
                                       "wKAzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/002y/+ThuP/xr7y/83G8/81G8H/MxnA/zMZwP+IeuD/inzg/0o1yv8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwKAz" +
                                       "GcAAMxnAAP///wAzGcAAMxnAADMZwOYzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP9POcz/u7Pw//38//////////////////9iTtP/MxnA/zMZwP+9tPD/////" +
                                       "//39/v/Du/H/Yk/T/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwOczGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/3lp2//19Pz/////////////////////////" +
                                       "//+ekuf/MxnA/zMZwP+Bct3//////////////////v7//7Wt7v9CK8b/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAA" +
                                       "MxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/gXPe//7+////" +
                                       "///////////////////////////////X0vb/MxnA/zMZwP9CK8b//fz/////////////////////" +
                                       "///l4vr/WUXP/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP9hTdL/+vr+///////////////////////////////////////8+///Nh7B/zMZwP8z" +
                                       "GcD/0Mv2////////////////////////////8/L9/15M0v8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zQawP/Y1Pf/////////////////////////////////" +
                                       "////////////////QCjF/zMZwP8zGcD/lIjk//////////////////////////////////Hv/P9P" +
                                       "Ocz/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP//" +
                                       "/wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/3Ji2f//////////" +
                                       "///////////////////////////////////////39v3/NRzB/zMZwP8zGcD/VUDO////////////" +
                                       "///////////////////////////W0fb/Nx7C/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/7qz7//////////////////////////////////////////////////BufH/MxnA" +
                                       "/zMZwP8zGcD/MxnA/+Th+v//////////////////////////////////////koXj/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/+rn+///////////////////////////////" +
                                       "//////////////X0/v9VQM7/MxnA/zMZwP8zGcD/MxnA/6me6v//////////////////////////" +
                                       "////////////8O78/zoiw/8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAA" +
                                       "MxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/OSDC////////" +
                                       "/////////////////////////////////////v7//2xb1v8zGcD/MxnA/zMZwP8zGcD/MxnA/2lX" +
                                       "1f///////////////////////////////////////////4Fz3v8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/QSnG////////////////////////////////////////////zsn1/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zcewv/z8v3//////////////////////////////////////8G5" +
                                       "8f8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnA" +
                                       "ADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/Nh7B////////////////////////////" +
                                       "////////////////u7Pw/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP++tfH/////////////" +
                                       "/////////////////////////+3r+/8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/+bj+v//////////////////////////////////////3Nj4/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP9+bt3///////////////////////////////////////////83HsL/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/7qx7///////////////////////////////////////////" +
                                       "/3Nj2f8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP9CK8b//fz/////////////////////////////" +
                                       "//////////9BKcb/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAz" +
                                       "GcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/3lp2///////////////" +
                                       "//////////////////////////////f2/f9uXdf/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/0Mv2" +
                                       "//////////////////////////////////////86IsP/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zgfwv/o5vr/////////////////////////////////////////////////w7vx/4Fy" +
                                       "3f9SPc3/MxnA/zMZwP8zGcD/koXj/////////////////////////////////+fl+v8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP+Fdt//////////////////////////////" +
                                       "///////////////////////////////+/v//nJDn/zMZwP8zGcD/VUDO////////////////////" +
                                       "/////////////7eu7v8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnA" +
                                       "AP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP80GsD/" +
                                       "zMX0////////////////////////////////////////////////////////////+fn//z0lxP8z" +
                                       "GcD/MxnA/+Th+v///////////////////////////21c1/8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/RS3H/+nn+///////////////////////////////////////" +
                                       "/////////////////////3Vl2/8zGcD/MxnA/6ec6f//////////////////////0s31/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/1I9zf/q5/v/////" +
                                       "/////////////////////////////////////////////////7Wt7v8zGcD/MxnA/2lX1f//////" +
                                       "///////////z8v3/VUHP/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP9NNsv/2NP3////////////////////////////////////////////////" +
                                       "/+/t+/81G8H/MxnA/zcewv/s6vv///////r6/v9qWdb/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAAMxnAADMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/OB/C/5mN5f/49/7/////////" +
                                       "//////////////////////////////////9iTtP/MxnA/zMZwP9aRtD/oJXn/15M0v8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcAAMxnAAP///wAzGcAA" +
                                       "MxnAADMZwO4zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP9ON8v/qJ7q//Py/f////////////////////////////////+glef/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwO8zGcAAMxnAAP///wAzGcAAMxnAADMZwKIzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/z0lxP94aNv/qp/r/8nC8//b" +
                                       "1/f/5eL6/9nV+P+QguP/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwKMzGcAAMxnAAP///wAzGcAAMxnAADMZwBwzGcDqMxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA6jMZwBwzGcAAMxnAAP//" +
                                       "/wAzGcAAMxnAADMZwAAzGcAlMxnAyzMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcDLMxnAJTMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAAjMZwGIzGcDmMxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA5jMZwGIzGcACMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAMMxnAhDMZwPgzGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwPYzGcCEMxnADDMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwCQzGcCuMxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnArjMZwCQzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAQDMZwM4zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZ" +
                                       "wM4zGcBAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAIzGcBmMxnA6zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8z" +
                                       "GcD/MxnA/zMZwP8zGcDrMxnAZDMZwAIzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAEDMZwIwzGcD5MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/" +
                                       "MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA+TMZwIwzGcAQMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAkMxnArzMZwP8zGcD/MxnA" +
                                       "/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcCuMxnAJDMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwEgzGcDVMxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA/zMZwP8zGcD/MxnA" +
                                       "1TMZwEgzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAEMxnAajMZwOszGcD/MxnA/zMZ" +
                                       "wP8zGcD/MxnA/zMZwOszGcBqMxnABDMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "ADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAAP///wAzGcAAMxnAADMZwAAzGcAA" +
                                       "MxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAz" +
                                       "GcAAMxnAADMZwBAzGcCDMxnA3TMZwPkzGcDdMxnAgzMZwBAzGcAAMxnAADMZwAAzGcAAMxnAADMZ" +
                                       "wAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnAADMZwAAzGcAAMxnA" +
                                       "AP//+A/////////gA////////8AB////////AAB///////wAAB//////8AAAB//////gAAAD////" +
                                       "/4AAAAD////+AAAAAD////gAAAAAD///8AAAAAAH///gAAAAAAP//+AAAAAAA///4AAAAAAD///g" +
                                       "AAAAAAP//+AAAAAAA///4AAAAAAD///gAAAAAAP//+AAAAAAA///4AAAAAAD///gAAAAAAP//+AA" +
                                       "AAAAA///4AAAAAAD///gAAAAAAP//+AAAAAAA///4AAAAAAD///gAAAAAAP//+AAAAAAA///4AAA" +
                                       "AAAD///gAAAAAAP//+AAAAAAA///4AAAAAAD///gAAAAAAP//+AAAAAAA///4AAAAAAD///gAAAA" +
                                       "AAP//+AAAAAAA///8AAAAAAH///4AAAAAA////4AAAAAP////4AAAAD/////4AAAA//////wAAAH" +
                                       "//////wAAB///////wAAf///////wAH////////gA/////////gP/////w==";
        #endregion

    }
}
