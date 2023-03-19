namespace Chaaos.ViewModels;

public partial class LocalizationViewModel : BaseViewModel
{
	public string LocalizedText => Chaaos.Resources.Strings.AppResources.HelloMessage;
}
