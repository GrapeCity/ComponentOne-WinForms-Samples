using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.TreeView;
using C1.Win.ExpressionEditor;
using C1.Framework;

namespace CustomEngine
{
    public class CustomPresenter : CustomContentPresenter
    {

        private TextElement _textElement;

        public CustomPresenter()
        {
            Style.HorizontalAlignment = Alignment.Spread;
            Style.VerticalAlignment = Alignment.Spread;
            _textElement = new TextElement();
            _textElement.Style = new Style();
            _textElement.Style.HorizontalAlignment = Alignment.Spread;
            _textElement.Style.VerticalAlignment = Alignment.Spread;
            _textElement.Style.Margins = new Thickness(1);
            Child = _textElement;

        }

        public static C1ExpressionEditor Editor
        {
            get;
            set;
        }

        public override string ToolTipText
        {
            get { return string.Empty; }
        }

        public override void SetFormat(string format)
        {
            
        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            base.SetStyle(styles);
            _textElement.Style.Font = styles.Font;                       
        }

        public override void SetValue(object value)
        {
            if (Node.Level == 0)
            {
                Editor.ItemContext = Node.GetValue();
                var res = Editor.Evaluate();
                if (Editor.IsValid)
                {
                    _textElement.Text = res.ToString();
                }
                else
                    _textElement.Text = "Error";
            }
            else
                _textElement.Text = value.ToString();            
        }
    }
}
