﻿namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenLayout component.
    /// </summary>
    public partial class RadzenLayout : RadzenComponentWithChildren
    {
        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-layout";
        }
    }
}
