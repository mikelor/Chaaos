using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaaos.Platforms.Android.AndroidAuto.Screens
{
    public class AutoMenuScreen : Screen
    {
        public AutoMenuScreen(CarContext carContext) : base(carContext)
        {   
        }

        public override ITemplate OnGetTemplate()
        {
            var itemList = new ItemList.Builder()
                .SetNoItemsMessage("Our Maui App Running on Android Auto")
                .Build();

            return new ListTemplate.Builder()
                .SetTitle("Maui Android Auto")
                .SetSingleList(itemList)
                .Build();
        }
    }
}
