using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.C1ZoomPages.Help_Forms
{
    public partial class ZoomPolicyForm : Form
    {
        private string _titleText = "ZoomPolicy sample for ";
        private Font _font = new System.Drawing.Font("Harlow Solid", 12);

        public ZoomPolicyForm(IZoomPolicyProvider provider, string group, string zoomPolicy)
        {
            InitializeComponent();
            ZoomPolicy policy1 = provider.GetZoomPolicy(group, zoomPolicy);
            ZoomPolicy policy2 = provider.GetZoomPolicy(group, zoomPolicy);
            if (policy1 == null || policy2 == null)
            {
                for (int i = 0; i < C1ZoomPanel2.DefaultZoomPolicies.Count; i++)
                {
                    if (C1ZoomPanel2.DefaultZoomPolicies[i].GetType().Name == zoomPolicy)
                    {
                        policy2 = C1ZoomPanel2.DefaultZoomPolicies[i];
                        policy2.Enabled = false;
                        break;
                    }
                }
            }
            else
            {
                policy2.Enabled = false;
                C1ZoomPanel1.ZoomPolicies.Add(policy1);
                C1ZoomPanel2.ZoomPolicies.Add(policy2);
            }

            if (policy2 != null)
            {
                this.Text = _titleText + policy2.TargetType.Name;
                Control control = provider.GetControl(group, zoomPolicy, _font, C1ZoomPanel1.ClientSize);
                if (control == null)
                {
                    return;
                }
                string targetControlName = zoomPolicy;
                if (targetControlName.EndsWith("Policy", StringComparison.OrdinalIgnoreCase))
                {
                    targetControlName = targetControlName.Substring(0, targetControlName.Length - "Policy".Length);
                }
                if (targetControlName.EndsWith("Zoom", StringComparison.OrdinalIgnoreCase))
                {
                    targetControlName = targetControlName.Substring(0, targetControlName.Length - "Zoom".Length);
                }
                if (control.GetType().Name != targetControlName)
                {
                    Queue<Control> controls = new Queue<Control>();
                    controls.Enqueue(control);
                    Control tmpControl;
                    while (controls.Count > 0)
                    {
                        tmpControl = controls.Dequeue();
                        if (tmpControl.GetType().Name == targetControlName)
                        {
                            break;
                        }
                        ZoomPolicy policy3 = provider.GetZoomPolicy(group, tmpControl.GetType().Name + "ZoomPolicy");
                        ZoomPolicy policy4 = provider.GetZoomPolicy(group, tmpControl.GetType().Name + "ZoomPolicy");
                        if (policy3 == null)
                        {
                            policy3 = provider.GetZoomPolicy(group, tmpControl.GetType().Name + "Policy");
                            policy4 = provider.GetZoomPolicy(group, tmpControl.GetType().Name + "Policy");
                        }
                        if (policy3 != null && !Contains(C1ZoomPanel1.ZoomPolicies, policy3))
                        {
                            C1ZoomPanel1.ZoomPolicies.Add(policy3);
                            C1ZoomPanel2.ZoomPolicies.Add(policy4);
                        }
                        foreach (Control childControl in tmpControl.Controls)
                        {
                            if (childControl.GetType().Assembly == typeof(Control).Assembly)
                            {
                                continue;
                            }
                            controls.Enqueue(childControl);
                        }
                    }                    
                }
                C1ZoomPanel1.Controls.Add(control);
                C1ZoomPanel2.Controls.Add(provider.GetControl(group, zoomPolicy, _font, C1ZoomPanel2.ClientSize));
            }
            Size? size = provider.GetDemoSize(group, zoomPolicy);
            if (size.HasValue)
            {
                this.Size = size.Value;
            }
        }

        private static bool Contains(List<ZoomPolicy> list, ZoomPolicy item)
        {
            foreach (ZoomPolicy policy in list)
            {
                if (policy.TargetType == item.TargetType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
