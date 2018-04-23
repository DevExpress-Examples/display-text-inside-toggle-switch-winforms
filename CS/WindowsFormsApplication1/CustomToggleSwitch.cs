using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomToggle : RepositoryItemToggleSwitch
    {
        static RepositoryItemCustomToggle() { RegisterCustomToggle(); }

        public RepositoryItemCustomToggle()
        {
                
        }

        public const string CustomToggleName = "CustomToggle";

        public override string EditorTypeName { get { return CustomToggleName; } }

        public override DevExpress.Utils.HorzAlignment GlyphAlignment
        {
            get
            {
                return DevExpress.Utils.HorzAlignment.Center;
            }
           
        }

        public static void RegisterCustomToggle()
        {
                              
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomToggleName,
                typeof(CustomToggle), typeof(RepositoryItemCustomToggle),
                typeof(ToggleSwitchViewInfo), new CustomToggleSwitchPainter(), true));
        }

            
    }

    [ToolboxItem(true)]
    public class CustomToggle : ToggleSwitch
    {
                       
        static CustomToggle() { RepositoryItemCustomToggle.RegisterCustomToggle(); }

        public CustomToggle()
        {
               
        }

         
        public override string EditorTypeName
        {
            get
            {
                return
                    RepositoryItemCustomToggle.CustomToggleName;
            }
        }

           
        [System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomToggle Properties
        {
            get { return base.Properties as RepositoryItemCustomToggle; }
        }

    }    
}
