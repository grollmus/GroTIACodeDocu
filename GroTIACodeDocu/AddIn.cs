using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;
using Siemens.Engineering.AddIn.Menu;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.Settings;
using System.Windows.Forms;
using System.IO;


namespace GroTIACodeDocu
{
    public class AddIn : ContextMenuAddIn
    {
        TiaPortal _tiaportal;

        private const string s_DisplayNameOfAddIn = " GroTIACodeDocu";

        public AddIn(TiaPortal tiaportal) : base(s_DisplayNameOfAddIn)
        {
            _tiaportal = tiaportal;
        }

        protected override void BuildContextMenuItems(ContextMenuAddInRoot addInRootSubmenu)
        {
            addInRootSubmenu.Items.AddActionItem<CodeBlockLibraryType>(
                ("Generate Docu"), OnDoSomething, OnCanSomething);

            addInRootSubmenu.Items.AddActionItem<Project>(
                ("Not available here"), OnClickProject);
        }

        private async void OnDoSomething(MenuSelectionProvider<CodeBlockLibraryType>
            menuSelectionProvider)
        {
            MessageBox.Show("Geht gleich los");
            IEnumerable<CodeBlockLibraryType> selection = menuSelectionProvider.GetSelection<CodeBlockLibraryType>();

            List<string> typeList = new List<string>();

            foreach (CodeBlockLibraryType actLibraryType in selection)
            {
                try
                {
                    //actLibraryType.Versions.Last().Export(new FileInfo(@"c:\temp\export.xml"), ExportOptions.WithDefaults);
                    
                    DocuHelper.HTMLGenerator htmlGenerator = new DocuHelper.HTMLGenerator (actLibraryType);
                    File.WriteAllText("C:\\CDoku\\UserDocumentation\\de-DE\\Library types\\" + actLibraryType.Name + ".htm", htmlGenerator.Result);
                    typeList.Add(actLibraryType.Name);
                } catch
                {
                    MessageBox.Show("None found");
                }
            }

            DocuHelper.HomeGenerator homeGenerator = new DocuHelper.HomeGenerator(typeList);
            File.WriteAllText("C:\\CDoku\\UserDocumentation\\de-DE\\home.htm", homeGenerator.Result);
        }

        private MenuStatus OnCanSomething(MenuSelectionProvider<CodeBlockLibraryType> menuSelectionProvider)
        {
            return MenuStatus.Enabled;
        }

        private void OnClickProject(MenuSelectionProvider<Project> menuSelectionProvider)
        {
        }

        private MenuStatus OnStatusUpdateProject(MenuSelectionProvider<Project> menuSelectionProvider)
        {
            return MenuStatus.Disabled;
        }
    }
}
