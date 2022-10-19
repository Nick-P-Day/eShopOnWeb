﻿using Microsoft.AspNetCore.Components;

namespace BlazorAdmin.Helpers;

public class BlazorLayoutComponent : LayoutComponentBase
{
    private readonly RefreshBroadcast _refresh = RefreshBroadcast.Instance;

    public void CallRequestRefresh()
    {
        _refresh.CallRequestRefresh();
    }

    protected override void OnInitialized()
    {
        _refresh.RefreshRequested += DoRefresh;
        base.OnInitialized();
    }

    private void DoRefresh()
    {
        StateHasChanged();
    }
}
