using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using Chaaos.Platforms.Android.Auto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace Chaaos.Platforms.Android.Auto.Screens;

public class MainScreen : Screen
{
    public MainScreen(CarContext carContext) : base(carContext)
    {
    }

    public override ITemplate OnGetTemplate()
    {
        var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
        var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

        var messageTemplateScreen = new Row.Builder()
            .SetTitle("Message Template")
            .AddText("Sample Text")
            .SetImage(dotnetBotCarIcon)
            .SetBrowsable(true)
            .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AndroidAutoScreen.MessageTemplate))
            .Build();

        var paneTemplateScreen = new Row.Builder()
            .SetTitle("Pane Template")
            .AddText("Sample Text")
            .SetImage(dotnetBotCarIcon)
            .SetBrowsable(true)
            .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AndroidAutoScreen.PaneTemplate))
            .Build();

        var gridTemplateScreen = new Row.Builder()
            .SetTitle("Grid Template")
            .AddText("Sample Text")
            .SetImage(dotnetBotCarIcon)
            .SetBrowsable(true)
            .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AndroidAutoScreen.GridTemplate))
            .Build();

        var placeListMapTemplateScreen = new Row.Builder()
            .SetTitle("PlaceListMap Template")
            .AddText("Sample Text")
            .SetImage(dotnetBotCarIcon)
            .SetBrowsable(true)
            .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, Enums.AndroidAutoScreen.PlaceListMapTemplate))
            .Build();

        var itemList = new ItemList.Builder()
            .SetNoItemsMessage("Our Maui App Running on Android Auto")
            .AddItem(messageTemplateScreen)
            .AddItem(paneTemplateScreen)
            .AddItem(gridTemplateScreen)
            .AddItem(placeListMapTemplateScreen)
            .Build();

        return new ListTemplate.Builder()
            .SetTitle("Maui Android Auto")
            .SetHeaderAction(Action.AppIcon)
            .SetSingleList(itemList)
            .Build();
    }
}