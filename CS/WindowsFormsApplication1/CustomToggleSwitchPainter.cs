using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class CustomToggleSwitchPainter : ToggleSwitchPainter
    {
        public CustomToggleSwitchPainter()
            : base()
        { }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            BaseCheckEditViewInfo vi = info.ViewInfo as BaseCheckEditViewInfo;
            vi.CheckInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            ToggleObjectInfoArgs args = (vi.CheckInfo) as ToggleObjectInfoArgs;

            if (args.GlyphRect.X == args.SwitchRect.X)
                vi.CheckInfo.CaptionRect = new Rectangle(args.SwitchRect.Right, args.SwitchRect.Y, args.SwitchRect.Width, args.SwitchRect.Height);
            else
                if (args.GlyphRect.Right == args.SwitchRect.Right)
                    vi.CheckInfo.CaptionRect = new Rectangle(args.GlyphRect.X, args.GlyphRect.Y, args.SwitchRect.Width, args.SwitchRect.Height);
                      
            base.DrawContent(info);
        }
    }
}
