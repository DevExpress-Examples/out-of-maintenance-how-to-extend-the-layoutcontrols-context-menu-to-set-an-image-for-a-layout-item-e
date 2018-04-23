using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraLayout;


namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
      
        private void OnLayoutControlShowContextMenu(object sender, DevExpress.XtraLayout.LayoutMenuEventArgs e) {
            if(layoutControl1.CustomizationForm != null && layoutControl1.CustomizationForm.Visible &&
                e.HitInfo.Item != null) {
                LayoutControlItem layoutItem = e.HitInfo.Item as LayoutControlItem;
                if(layoutItem == null) return;
                if(layoutItem.Image == null) 
                    e.Menu.Items.Add(CreateCustomMenuItem("&Add Image", OnAddImage, layoutItem, Properties.Resources.Dock));
                else 
                    e.Menu.Items.Add(CreateCustomMenuItem("&Remove Image", OnRemoveImage, layoutItem, null));
            }
        }

        private DXMenuItem CreateCustomMenuItem(string caption, EventHandler handler, LayoutControlItem layoutItem, Image img) {
            DXMenuItem item = new DXMenuItem(caption, handler, img);
            item.Tag = layoutItem;
            return item;
        }

        Size imageSize = new Size(20, 20);

        void OnAddImage(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    LayoutControlItem layoutItem = item.Tag as LayoutControlItem;
                    Bitmap bmp = new Bitmap(img, imageSize);
                    layoutItem.Tag = layoutItem.TextVisible;
                    if(!layoutItem.TextVisible) {
                        layoutItem.TextVisible = true;
                        layoutItem.TextAlignMode = TextAlignModeItem.CustomSize;
                        layoutItem.TextSize = imageSize;
                    }
                    layoutItem.Image = bmp;
                }
                catch { }
            }
        }

        void OnRemoveImage(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            LayoutControlItem layoutItem = item.Tag as LayoutControlItem;
            if(layoutItem.Tag != null && layoutItem.Tag is bool)
                layoutItem.TextVisible = (bool)layoutItem.Tag;
            layoutItem.Image = null;
        }
    }
}
