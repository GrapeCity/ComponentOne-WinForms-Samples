using GrapeCity.Win.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public class ZoomPolicyProvider : ZoomPolicyProviderBase
    {
        private const string InputMan = "InputMan";
        private const string PlusPak = "PlusPak";
        private const string ComponentOne = "ComponentOne";
        private const string ActiveReports = "ActiveReports";
        private const string Spread = "Spread";
        private const string LeadTools = "LeadTools";
        private const string VBPowerPacks = "VBPowerPacks";
        private const string WPFElmentHost ="WPF_ElementHost";

        private string[] _products = new string[] 
        {
            Standard,
            InputMan,
            PlusPak,
            ComponentOne,
            ActiveReports,
            Spread,
            LeadTools,
            VBPowerPacks,
            WPFElmentHost
        };
        
        public override string[] PolicyGroups
        {
            get { return _products; }
        }

        public override string[] GetZoomPolicies(string policyGroup)
        {
            switch (policyGroup)
            {
                case Standard:
                    return base.GetZoomPolicies(policyGroup);
                case InputMan:
                    return InputManCreater.InputManPolicies;
                case PlusPak:
                    return PlusPakCreater.PlusPakPolicies;
                case ComponentOne:
                    return ComponentOneCreater.ComponentOnePolicies;
                case Spread:
                    return SpreadCreater.SpreadPolicies;
                case ActiveReports:
                    return ActiveReportsCreater.ActiveReportsPolicies;
                case LeadTools:
                    return LeadToolsCreater.LeadToolsPolicies;
                case VBPowerPacks:
                    return VBPowerPacksCreater.VBPowerPacksPolicies;
                case WPFElmentHost:
                    return WPFElmentHostCreater.WPFElmentHostPolicies;               
                default:
                    break;
            }
            return new string[0];
        }

        private static Dictionary<string, ConstructorInfo> _zoomPolicyTypes;

        public override ZoomPolicy GetZoomPolicy(string policyGroup, string zoomPolicy)
        {
            if (policyGroup == Standard)
            {
                return base.GetZoomPolicy(policyGroup, zoomPolicy);
            }
            if (_zoomPolicyTypes == null)
            {
                _zoomPolicyTypes = new Dictionary<string, ConstructorInfo>();
                Type[] types = typeof(ZoomPolicyProvider).Assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (typeof(ZoomPolicy).IsAssignableFrom(type)
                        && !type.IsAbstract)
                    {
                        ConstructorInfo constructor = type.GetConstructor(new Type[0]);
                        if (constructor != null)
                        {
                            _zoomPolicyTypes.Add(type.Name, constructor);
                        }
                    }
                }
            }
            ConstructorInfo policy;
            if(_zoomPolicyTypes.TryGetValue(zoomPolicy, out policy))
            {
                return policy.Invoke(new object[0]) as ZoomPolicy;
            }
            return base.GetZoomPolicy(policyGroup, zoomPolicy);
        }

        public override string GetDescription(string policyGroup, string zoomPolicy)
        {
            switch (policyGroup)
            {
                case Standard:
                    return base.GetDescription(policyGroup, zoomPolicy);
                case InputMan:
                    return InputManCreater.GetDescription(zoomPolicy);
                case PlusPak:
                    return PlusPakCreater.GetDescription(zoomPolicy);
                case ComponentOne:
                    return ComponentOneCreater.GetDescription(zoomPolicy);
                case Spread:
                    return SpreadCreater.GetDescription(zoomPolicy);
                case ActiveReports:
                    return ActiveReportsCreater.GetDescription(zoomPolicy);
                case LeadTools:
                    return LeadToolsCreater.GetDescription(zoomPolicy);
                case VBPowerPacks:
                    return VBPowerPacksCreater.GetDescription(zoomPolicy);
                case WPFElmentHost:
                    return WPFElmentHostCreater.GetDescription(zoomPolicy);
                default:
                    break;
            }
            return base.GetDescription(policyGroup, zoomPolicy);
        }

        public override Control GetControl(string policyGroup, string zoomPolicy, Font font, Size layoutSize)
        {
            switch (policyGroup)
            {
                case Standard:
                    return base.GetControl(policyGroup, zoomPolicy, font, layoutSize);
                case InputMan:
                    return InputManCreater.CreateControl(zoomPolicy, font, layoutSize);
                case PlusPak:
                    return PlusPakCreater.CreateControl(zoomPolicy, font, layoutSize);
                case ComponentOne:
                    return ComponentOneCreater.CreateControl(zoomPolicy, font, layoutSize);
                case Spread:
                    return SpreadCreater.CreateControl(zoomPolicy, font, layoutSize);
                case ActiveReports:
                    return ActiveReportsCreater.CreateControl(zoomPolicy, font, layoutSize);
                case LeadTools:
                    return LeadToolsCreater.CreateControl(zoomPolicy, font, layoutSize);
                case VBPowerPacks:
                    return VBPowerPacksCreater.CreateControl(zoomPolicy, font, layoutSize);;
                case WPFElmentHost:
                    return WPFElmentHostCreater.CreateControl(zoomPolicy, font, layoutSize);
                default:
                    break;
            }
            return base.GetControl(policyGroup, zoomPolicy, font, layoutSize);
        }

        public override Size? GetDemoSize(string policyGroup, string zoomPolicy)
        {
            if (policyGroup == ComponentOne)
            {
                return ComponentOneCreater.GetDemoSize(zoomPolicy);
            }
            return null;
        }
    }
}
