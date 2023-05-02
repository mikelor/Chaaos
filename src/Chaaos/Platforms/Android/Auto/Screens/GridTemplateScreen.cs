using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chaaos.Platforms.Android.Auto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace Chaaos.Platforms.Android.Auto.Screens
{
    internal class GridTemplateScreen : Screen
    {
        public GridTemplateScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var gridItemListBuilder = new ItemList.Builder().SetNoItemsMessage("No Grid Items Found");

            for(var i  = 0; i < 10; i++)
            {
                var gridItem = new GridItem.Builder()
                    .SetTitle($"Grid Item {i} Title")
                    .SetText($"Grid Item {i} Text")
                    .SetImage(dotnetBotCarIcon)
                    .SetOnClickListener(new ActionOnClickListener(CarContext, $"Grid item {i} was tapped"))
                    .Build();

                gridItemListBuilder.AddItem(gridItem);
            }

            var gridItemList = gridItemListBuilder.Build();

            var actionOne = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action Strip Item 1 was Tapped"))
                .Build();

            var actionTwo = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action Strip Item 2 was Tapped"))
                .Build();

            var actionStrip = new ActionStrip.Builder()
                .AddAction(actionOne)
                .AddAction(actionTwo)
                .Build();



            return new GridTemplate.Builder()
                .SetTitle("Maui Android Auto - Grid Template")
                .SetHeaderAction(Action.Back)
                .SetSingleList(gridItemList)
                .SetActionStrip(actionStrip)
                .Build();
        }
    }
}
