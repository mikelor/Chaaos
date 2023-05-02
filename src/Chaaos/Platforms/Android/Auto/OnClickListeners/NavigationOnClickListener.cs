using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chaaos.Platforms.Android.Auto.Enums;
using Chaaos.Platforms.Android.Auto.Screens;

namespace Chaaos.Platforms.Android.Auto.OnClickListeners
{
    public class NavigationOnClickListener : Java.Lang.Object, IOnClickListener
    {
        private readonly CarContext mCarContext;
        private readonly ScreenManager mScreenManager;
        private readonly AndroidAutoScreen mScreenToNavigateTo;

        public NavigationOnClickListener(CarContext carContext, ScreenManager screenManager, AndroidAutoScreen screenToNavigateTo)
        {
            this.mCarContext = carContext;
            this.mScreenManager = screenManager;
            this.mScreenToNavigateTo =  screenToNavigateTo;
                
        }
        void IOnClickListener.OnClick()
        {
            switch(this.mScreenToNavigateTo)
            {
                case AndroidAutoScreen.None:
                    return;

                case AndroidAutoScreen.Menu:
                    this.mScreenManager.Push(new MainScreen(this.mCarContext));
                    break;

                case AndroidAutoScreen.MessageTemplate:
                    this.mScreenManager.Push(new MessageTemplateScreen(this.mCarContext));
                    break;

                case AndroidAutoScreen.PaneTemplate:
                    this.mScreenManager.Push(new PaneTemplateScreen(this.mCarContext));
                    break;

                case AndroidAutoScreen.GridTemplate:
                    this.mScreenManager.Push(new GridTemplateScreen(this.mCarContext));
                    break;

                case AndroidAutoScreen.PlaceListMapTemplate:
                    this.mScreenManager.Push(new PlaceListMapScreen(this.mCarContext));
                    break;

                case AndroidAutoScreen.Pop:
                    this.mScreenManager.Pop();
                    break;

                default:
                    return;

            }
        }
    }
}
