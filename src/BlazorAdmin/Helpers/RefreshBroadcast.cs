using System;

namespace BlazorAdmin.Helpers;

internal sealed class RefreshBroadcast
{
    private static readonly Lazy<RefreshBroadcast>
        Lazy =
            new Lazy<RefreshBroadcast>
                (() => new RefreshBroadcast());

    private RefreshBroadcast()
    {
    }

    public event Action RefreshRequested;

    public static RefreshBroadcast Instance => Lazy.Value;

    public void CallRequestRefresh()
    {
        RefreshRequested?.Invoke();
    }
}
