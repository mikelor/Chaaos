using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Java.Nio.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chaaos.Platforms.Android.Auto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace Chaaos.Platforms.Android.Auto.Screens
{
    public class MessageTemplateScreen : Screen
    {
        public MessageTemplateScreen(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();


            var acceptAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetTitle("Accept")
                .SetBackgroundColor(CarColor.Green)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Accept was Tapped"))
                .Build();

            var cancelAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetTitle("Cancel")
                .SetBackgroundColor(CarColor.Red)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Cancel was Tapped"))
                .Build();

            return new MessageTemplate.Builder("This is a Message Template")
                .SetTitle("Maui Android Auto")
                .SetHeaderAction(Action.Back)
                .SetIcon(dotnetBotCarIcon)
                .AddAction(acceptAction)
                .AddAction(cancelAction)
                .Build();
        }
    }
}
