using C1.Win.Ribbon;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CustomStateImages
{
    public partial class ImageEditor : C1RibbonForm
    {
        public ImageEditor(ImageList imgList)
        {
            InitializeComponent();
            ImgList = imgList;
            lvImages.StateImageList = new ImageList();
            FillCombobox(cmbImageTypes);
            cmbImageTypes.SelectedIndex = 0;
            FillImages();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "All image files (*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddItem(Image.FromFile(ofd.FileName), cmbImageTypes.SelectedItem.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvImages.SelectedItems.Count > 0)
                RemoveItem(lvImages.SelectedItems[0].Name);
        }

        private void FillImages()
        {
            foreach(var key in ImgList.Images.Keys)
            {
                AddItem(ImgList.Images[key], key);
            }
        }

        protected void AddItem(Image image, string name)
        {
            RemoveItem(name);

            lvImages.StateImageList.Images.Add(name, image);

            var item = new ListViewItem();
            item.StateImageIndex = lvImages.StateImageList.Images.IndexOfKey(name);
            item.Name = name;
            item.Text = name;
            lvImages.Items.Add(item);
        }

        private void RemoveItem(string name)
        {
            if (lvImages.StateImageList.Images.ContainsKey(name))
                lvImages.StateImageList.Images.RemoveByKey(name);

            if (lvImages.Items.ContainsKey(name))
                lvImages.Items.RemoveByKey(name);

            foreach (ListViewItem item in lvImages.Items)
                item.StateImageIndex = lvImages.StateImageList.Images.IndexOfKey(item.Name);
        }

        protected virtual void FillCombobox(ComboBox cmb)
        {

        }

        protected ImageList ImgList
        {
            get;
            set;
        }

        public void FillImageList()
        {
            ImgList.Images.Clear();
            foreach(ListViewItem item in lvImages.Items)
                ImgList.Images.Add(item.Name, lvImages.StateImageList.Images[item.StateImageIndex]);            
        }
    }

    public class CheckStateImageEditor : ImageEditor
    {
        public CheckStateImageEditor(ImageList imgList) : base(imgList)
        {

        }

        protected override void FillCombobox(ComboBox cmb)
        {
            foreach (string key in Enum.GetNames(typeof(CheckBoxState)))
            {
                if (ImgList.Images.ContainsKey(key))
                    AddItem(ImgList.Images[key], key);
                cmb.Items.Add(key);
            }            
        }
    }

    public class ButtonStateImageEditor : ImageEditor
    {
        public ButtonStateImageEditor(ImageList imgList) : base(imgList)
        {

        }

        protected override void FillCombobox(ComboBox cmb)
        {
            AddCmbItem(cmb, "CollapsedNormal");
            AddCmbItem(cmb, "CollapsedHot");
            AddCmbItem(cmb, "CollapsedPressed");
            AddCmbItem(cmb, "CollapsedDisabled");
            AddCmbItem(cmb, "ExpandedNormal");
            AddCmbItem(cmb, "ExpandedHot");
            AddCmbItem(cmb, "ExpandedPressed");
            AddCmbItem(cmb, "ExpandedDisabled");
        }

        private void AddCmbItem(ComboBox cmb, string key)
        {
            if (ImgList.Images.ContainsKey(key))
                AddItem(ImgList.Images[key], key);
            cmb.Items.Add(key);
        }
    }
}
