using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Tile;

namespace ControlExplorer.Tiles
{
    public partial class AppsPanel : C1DemoForm
    {
        const int _palX = 20;
        const int _palY = 16;

        int _currentIndex = 10;

        public AppsPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cx = _palX;
            Graphics g = e.Graphics;

            DrawRect(g, ref cx, Color.FromArgb(37, 37, 37), Color.FromArgb(244, 179, 0));
            DrawRect(g, ref cx, Color.FromArgb(37, 37, 37), Color.FromArgb(120, 186, 0));
            DrawRect(g, ref cx, Color.FromArgb(37, 37, 37), Color.FromArgb(38, 115, 236));
            DrawRect(g, ref cx, Color.FromArgb(37, 37, 37), Color.FromArgb(174, 17, 61));
            DrawRect(g, ref cx, Color.FromArgb(46, 23, 0), Color.FromArgb(99, 47, 0));
            DrawRect(g, ref cx, Color.FromArgb(78, 0, 0), Color.FromArgb(176, 30, 0));
            DrawRect(g, ref cx, Color.FromArgb(78, 0, 56), Color.FromArgb(193, 0, 79));
            DrawRect(g, ref cx, Color.FromArgb(45, 0, 78), Color.FromArgb(114, 0, 172));
            DrawRect(g, ref cx, Color.FromArgb(31, 0, 104), Color.FromArgb(70, 23, 180));
            DrawRect(g, ref cx, Color.FromArgb(0, 30, 78), Color.FromArgb(0, 106, 193));
            DrawRect(g, ref cx, Color.FromArgb(0, 77, 96), Color.FromArgb(0, 130, 135));
            DrawRect(g, ref cx, Color.FromArgb(0, 74, 0), Color.FromArgb(25, 153, 0));
            DrawRect(g, ref cx, Color.FromArgb(21, 153, 42), Color.FromArgb(0, 193, 63));
            DrawRect(g, ref cx, Color.FromArgb(229, 108, 25), Color.FromArgb(255, 152, 29));
            DrawRect(g, ref cx, Color.FromArgb(184, 27, 27), Color.FromArgb(255, 46, 18));
            DrawRect(g, ref cx, Color.FromArgb(184, 27, 108), Color.FromArgb(255, 29, 119));
            DrawRect(g, ref cx, Color.FromArgb(105, 27, 184), Color.FromArgb(170, 64, 255));
            DrawRect(g, ref cx, Color.FromArgb(27, 88, 184), Color.FromArgb(31, 174, 255));
            DrawRect(g, ref cx, Color.FromArgb(86, 156, 227), Color.FromArgb(86, 197, 255));
            DrawRect(g, ref cx, Color.FromArgb(0, 170, 170), Color.FromArgb(0, 216, 204));
            DrawRect(g, ref cx, Color.FromArgb(131, 186, 31), Color.FromArgb(145, 209, 0));
            DrawRect(g, ref cx, Color.FromArgb(211, 157, 9), Color.FromArgb(225, 183, 0));
            DrawRect(g, ref cx, Color.FromArgb(224, 100, 183), Color.FromArgb(255, 118, 188));
            DrawRect(g, ref cx, Color.FromArgb(105, 105, 105), Color.FromArgb(0, 164, 164));
            DrawRect(g, ref cx, Color.FromArgb(105, 105, 105), Color.FromArgb(255, 125, 35));

            SolidBrush pb = new SolidBrush(Color.FromArgb(35, 37, 34));
            int x = _currentIndex * 24 + _palX + 6;

            int y = _palY - 12;
            GraphicsPath path = new GraphicsPath();
            path.AddLines(new Point[] {
                new Point(x, y),
                new Point(x + 12, y),
                new Point(x + 12, y + 3),
                new Point(x + 6, y + 9),
                new Point(x + 6, y + 9),
                new Point(x, y + 3)
            });
            path.CloseFigure();
            g.FillPath(pb, path);
            path.Dispose();

            y += 47;
            path = new GraphicsPath();
            path.AddLines(new Point[] {
                new Point(x, y),
                new Point(x + 12, y),
                new Point(x + 12, y - 3),
                new Point(x + 6, y - 9),
                new Point(x + 6, y - 9),
                new Point(x, y - 3)
            });
            path.CloseFigure();
            g.FillPath(pb, path);
            path.Dispose();

            pb.Dispose();
        }

        void DrawRect(Graphics g, ref int x, Color c1, Color c2)
        {
            SolidBrush b1 = new SolidBrush(c1);
            SolidBrush b2 = new SolidBrush(c2);

            g.FillRectangle(b1, x, _palY, 24, 24);
            g.FillRectangle(b2, x + 7, _palY + 7, 10, 10);
            x += 24;

            b1.Dispose();
            b2.Dispose();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X >= _palX && e.Y >= _palY && e.X < _palX + (25 * 24) && e.Y < _palY + 24)
                {
                    int newIndex = (e.X - _palX) / 24;
                    if (newIndex != _currentIndex)
                    {
                        UpdateColorPalette(newIndex);
                    }
                }
            }
        }

        void UpdateColorPalette(int newIndex)
        {
            PanelElement panel = (PanelElement)mapImgTemplate.Elements[0];
            ImageElement imageElem = (ImageElement)panel.Children[0];
            imageElem.ColumnIndex = newIndex;

            Color backColor = Color.Empty;
            Color checkBackColor = Color.Empty;
            Color hotBackColor = Color.Empty;
            Color hotCheckBackColor = Color.Empty;
            Color subgroupLineColor = Color.Empty;
            Color subgroupTitleColor = Color.Empty;

            switch (newIndex)
            {
                case 0:
                    backColor = Color.FromArgb(29, 29, 29);
                    checkBackColor = Color.FromArgb(244, 179, 0);
                    hotBackColor = Color.FromArgb(58, 58, 58);
                    hotCheckBackColor = Color.FromArgb(246, 188, 35);
                    subgroupLineColor = Color.FromArgb(38, 38, 38);
                    subgroupTitleColor = Color.FromArgb(255, 200, 63);
                    break;
                case 1:
                    backColor = Color.FromArgb(29, 29, 29);
                    checkBackColor = Color.FromArgb(118, 182, 0);
                    hotBackColor = Color.FromArgb(58, 58, 58);
                    hotCheckBackColor = Color.FromArgb(137, 192, 35);
                    subgroupLineColor = Color.FromArgb(38, 38, 38);
                    subgroupTitleColor = Color.FromArgb(139, 216, 0);
                    break;
                case 2:
                    backColor = Color.FromArgb(29, 29, 29);
                    checkBackColor = Color.FromArgb(38, 115, 236);
                    hotBackColor = Color.FromArgb(58, 58, 58);
                    hotCheckBackColor = Color.FromArgb(68, 133, 239);
                    subgroupLineColor = Color.FromArgb(38, 38, 38);
                    subgroupTitleColor = Color.FromArgb(54, 158, 255);
                    break;
                case 3:
                    backColor = Color.FromArgb(29, 29, 29);
                    checkBackColor = Color.FromArgb(174, 17, 61);
                    hotBackColor = Color.FromArgb(58, 58, 58);
                    hotCheckBackColor = Color.FromArgb(185, 50, 88);
                    subgroupLineColor = Color.FromArgb(38, 38, 38);
                    subgroupTitleColor = Color.FromArgb(240, 0, 67);
                    break;
                case 4:
                    backColor = Color.FromArgb(38, 19, 0);
                    checkBackColor = Color.FromArgb(99, 47, 0);
                    hotBackColor = Color.FromArgb(66, 50, 33);
                    hotCheckBackColor = Color.FromArgb(120, 76, 35);
                    subgroupLineColor = Color.FromArgb(51, 26, 0);
                    subgroupTitleColor = Color.FromArgb(209, 105, 22);
                    break;
                case 5:
                    backColor = Color.FromArgb(56, 0, 0);
                    checkBackColor = Color.FromArgb(176, 30, 0);
                    hotBackColor = Color.FromArgb(82, 33, 33);
                    hotCheckBackColor = Color.FromArgb(187, 61, 35);
                    subgroupLineColor = Color.FromArgb(74, 0, 0);
                    subgroupTitleColor = Color.FromArgb(255, 42, 0);
                    break;
                case 6:
                    backColor = Color.FromArgb(64, 0, 46);
                    checkBackColor = Color.FromArgb(193, 0, 79);
                    hotBackColor = Color.FromArgb(88, 32, 72);
                    hotCheckBackColor = Color.FromArgb(202, 35, 103);
                    subgroupLineColor = Color.FromArgb(78, 0, 56);
                    subgroupTitleColor = Color.FromArgb(244, 0, 133);
                    break;
                case 7:
                    backColor = Color.FromArgb(37, 0, 64);
                    checkBackColor = Color.FromArgb(114, 0, 172);
                    hotBackColor = Color.FromArgb(65, 33, 89);
                    hotCheckBackColor = Color.FromArgb(133, 35, 183);
                    subgroupLineColor = Color.FromArgb(51, 0, 87);
                    subgroupTitleColor = Color.FromArgb(196, 80, 255);
                    break;
                case 8:
                    backColor = Color.FromArgb(24, 0, 82);
                    checkBackColor = Color.FromArgb(70, 23, 180);
                    hotBackColor = Color.FromArgb(54, 33, 104);
                    hotCheckBackColor = Color.FromArgb(95, 55, 190);
                    subgroupLineColor = Color.FromArgb(33, 0, 110);
                    subgroupTitleColor = Color.FromArgb(146, 92, 255);
                    break;
                case 9:
                    backColor = Color.FromArgb(0, 25, 64);
                    checkBackColor = Color.FromArgb(0, 106, 193);
                    hotBackColor = Color.FromArgb(33, 55, 89);
                    hotCheckBackColor = Color.FromArgb(35, 126, 202);
                    subgroupLineColor = Color.FromArgb(0, 31, 82);
                    subgroupTitleColor = Color.FromArgb(50, 163, 255);
                    break;
                case 10:
                    backColor = Color.FromArgb(0, 64, 80);
                    checkBackColor = Color.FromArgb(0, 130, 135);
                    hotBackColor = Color.FromArgb(33, 89, 103);
                    hotCheckBackColor = Color.FromArgb(35, 146, 151);
                    subgroupLineColor = Color.FromArgb(0, 73, 92);
                    subgroupTitleColor = Color.FromArgb(82, 238, 255);
                    break;
                case 11:
                    backColor = Color.FromArgb(0, 62, 0);
                    checkBackColor = Color.FromArgb(25, 153, 0);
                    hotBackColor = Color.FromArgb(33, 87, 33);
                    hotCheckBackColor = Color.FromArgb(57, 167, 35);
                    subgroupLineColor = Color.FromArgb(0, 71, 0);
                    subgroupTitleColor = Color.FromArgb(38, 236, 0);
                    break;
                case 12:
                    backColor = Color.FromArgb(18, 128, 35);
                    checkBackColor = Color.FromArgb(0, 193, 63);
                    hotBackColor = Color.FromArgb(49, 144, 63);
                    hotCheckBackColor = Color.FromArgb(35, 202, 88);
                    subgroupLineColor = Color.FromArgb(20, 140, 40);
                    subgroupTitleColor = Color.FromArgb(0, 255, 83);
                    break;
                case 13:
                    backColor = Color.FromArgb(191, 90, 21);
                    checkBackColor = Color.FromArgb(255, 152, 29);
                    hotBackColor = Color.FromArgb(199, 111, 51);
                    hotCheckBackColor = Color.FromArgb(255, 166, 60);
                    subgroupLineColor = Color.FromArgb(201, 99, 30);
                    subgroupTitleColor = Color.FromArgb(255, 202, 96);
                    break;
                case 14:
                    backColor = Color.FromArgb(154, 22, 22);
                    checkBackColor = Color.FromArgb(255, 46, 18);
                    hotBackColor = Color.FromArgb(167, 52, 52);
                    hotCheckBackColor = Color.FromArgb(255, 75, 51);
                    subgroupLineColor = Color.FromArgb(171, 26, 26);
                    subgroupTitleColor = Color.FromArgb(255, 120, 67);
                    break;
                case 15:
                    backColor = Color.FromArgb(154, 22, 90);
                    checkBackColor = Color.FromArgb(255, 29, 119);
                    hotBackColor = Color.FromArgb(167, 52, 111);
                    hotCheckBackColor = Color.FromArgb(255, 60, 138);
                    subgroupLineColor = Color.FromArgb(168, 25, 99);
                    subgroupTitleColor = Color.FromArgb(255, 93, 192);
                    break;
                case 16:
                    backColor = Color.FromArgb(87, 22, 154);
                    checkBackColor = Color.FromArgb(170, 64, 255);
                    hotBackColor = Color.FromArgb(109, 52, 167);
                    hotCheckBackColor = Color.FromArgb(182, 90, 255);
                    subgroupLineColor = Color.FromArgb(101, 26, 176);
                    subgroupTitleColor = Color.FromArgb(82, 238, 255);
                    break;
                case 17:
                    backColor = Color.FromArgb(22, 73, 154);
                    checkBackColor = Color.FromArgb(31, 174, 255);
                    hotBackColor = Color.FromArgb(52, 97, 167);
                    hotCheckBackColor = Color.FromArgb(62, 185, 255);
                    subgroupLineColor = Color.FromArgb(25, 80, 168);
                    subgroupTitleColor = Color.FromArgb(0, 198, 255);
                    break;
                case 18:
                    backColor = Color.FromArgb(67, 144, 223);
                    checkBackColor = Color.FromArgb(86, 197, 255);
                    hotBackColor = Color.FromArgb(91, 158, 227);
                    hotCheckBackColor = Color.FromArgb(109, 205, 255);
                    subgroupLineColor = Color.FromArgb(88, 154, 219);
                    subgroupTitleColor = Color.FromArgb(65, 255, 255);
                    break;
                case 19:
                    backColor = Color.FromArgb(0, 142, 142);
                    checkBackColor = Color.FromArgb(0, 216, 204);
                    hotBackColor = Color.FromArgb(33, 157, 157);
                    hotCheckBackColor = Color.FromArgb(35, 221, 210);
                    subgroupLineColor = Color.FromArgb(0, 153, 153);
                    subgroupTitleColor = Color.FromArgb(0, 255, 241);
                    break;
                case 20:
                    backColor = Color.FromArgb(120, 170, 28);
                    checkBackColor = Color.FromArgb(145, 209, 0);
                    hotBackColor = Color.FromArgb(137, 181, 57);
                    hotCheckBackColor = Color.FromArgb(159, 215, 35);
                    subgroupLineColor = Color.FromArgb(128, 181, 29);
                    subgroupTitleColor = Color.FromArgb(185, 255, 20);
                    break;
                case 21:
                    backColor = Color.FromArgb(194, 144, 8);
                    checkBackColor = Color.FromArgb(225, 183, 0);
                    hotBackColor = Color.FromArgb(202, 158, 40);
                    hotCheckBackColor = Color.FromArgb(229, 193, 35);
                    subgroupLineColor = Color.FromArgb(199, 154, 30);
                    subgroupTitleColor = Color.FromArgb(255, 243, 47);
                    break;
                case 22:
                    backColor = Color.FromArgb(220, 79, 173);
                    checkBackColor = Color.FromArgb(255, 118, 188);
                    hotBackColor = Color.FromArgb(225, 102, 184);
                    hotCheckBackColor = Color.FromArgb(255, 137, 197);
                    subgroupLineColor = Color.FromArgb(229, 90, 183);
                    subgroupTitleColor = Color.FromArgb(255, 166, 198);
                    break;
                case 23:
                    backColor = Color.FromArgb(88, 88, 88);
                    checkBackColor = Color.FromArgb(0, 164, 164);
                    hotBackColor = Color.FromArgb(110, 110, 110);
                    hotCheckBackColor = Color.FromArgb(35, 175, 176);
                    subgroupLineColor = Color.FromArgb(97, 97, 97);
                    subgroupTitleColor = Color.FromArgb(0, 212, 212);
                    break;
                case 24:
                    backColor = Color.FromArgb(88, 88, 88);
                    checkBackColor = Color.FromArgb(255, 125, 35);
                    hotBackColor = Color.FromArgb(110, 110, 110);
                    hotCheckBackColor = Color.FromArgb(255, 143, 65);
                    subgroupLineColor = Color.FromArgb(97, 97, 97);
                    subgroupTitleColor = Color.FromArgb(255, 158, 56);
                    break;
            }

            c1TileControl1.BackColor = backColor;
            c1TileControl1.TileBackColor = backColor;
            c1TileControl1.CheckBackColor = checkBackColor;
            c1TileControl1.HotBackColor = hotBackColor;
            c1TileControl1.HotCheckBackColor = hotCheckBackColor;
            panel = (PanelElement)subgroupTemplate.Elements[0];
            TextElement textElem = (TextElement)panel.Children[1];
            textElem.ForeColor = subgroupTitleColor;
            panel = (PanelElement)panel.Children[0];
            panel.BackColor = subgroupLineColor;

            _currentIndex = newIndex;
            panel1.Invalidate();
        }
    }
}
