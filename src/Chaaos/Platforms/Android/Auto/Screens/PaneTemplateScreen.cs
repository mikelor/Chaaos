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
    internal class PaneTemplateScreen : Screen
    {
        public PaneTemplateScreen(CarContext carContext) : base(carContext)
        {

        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var paneAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetBackgroundColor(CarColor.Blue)
                .SetTitle("< Go Back")
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AndroidAutoScreen.Pop ))
                .Build();

            var paneBuilder = new Pane.Builder()
                .SetImage(dotnetBotCarIcon)
                .AddAction(paneAction);

            for (var i = 0; i < 10; i++)
            {
                var row = new Row.Builder()
                    .SetTitle($"Row {i} Title")
                    .SetImage(dotnetBotCarIcon)
                    .AddText($"Row {i} Text")
                    .Build();

                paneBuilder.AddRow(row);
            }

            var pane = paneBuilder.Build();

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

            return new PaneTemplate.Builder(pane)
                .SetTitle("Maui Android Auto")
                .SetHeaderAction(Action.Back)
                .SetActionStrip(actionStrip)
                .Build();
 
        }
    }
}
