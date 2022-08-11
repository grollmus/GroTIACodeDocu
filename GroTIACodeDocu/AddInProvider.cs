using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;
using Siemens.Engineering.AddIn;
using Siemens.Engineering.AddIn.Menu;

namespace GroTIACodeDocu
{

    public class AddInProvider : GlobalLibraryTreeAddInProvider
    {
        TiaPortal _tiaportal;

        public AddInProvider(TiaPortal tiaportal)
        {
            _tiaportal = tiaportal;
        }


        protected override IEnumerable<ContextMenuAddIn> GetContextMenuAddIns()
        {
            yield return new AddIn(_tiaportal);
        }
    }
}
