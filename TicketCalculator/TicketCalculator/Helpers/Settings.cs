using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace TicketCalculator.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings => CrossSettings.Current;
   
    private const string TicketValueKey = "TicketValueKey";
    private static readonly double TicketValueDefault = 7.66;

        
    public static double TicketValue
        {
      get
      {
        return AppSettings.GetValueOrDefault(TicketValueKey, TicketValueDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue(TicketValueKey, value);
      }
    }

  }
}