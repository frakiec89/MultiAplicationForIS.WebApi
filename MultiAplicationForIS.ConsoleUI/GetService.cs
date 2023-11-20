using MultiAplicationForIS.BLForAPI;
using MultiAplicationForIS.Core.Interfaces;

internal class GetService
{
    internal static IUserService GetUserService()
    {
        return new APIUserService();
    }
}