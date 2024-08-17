using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using CalendarButton = Avalonia.Controls.Primitives.CalendarButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarButtonEventsExtensions
{
    public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonDown(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerPressedEventArgs> action) => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonDown += h);
    public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonUp(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerReleasedEventArgs> action) => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonUp += h);
}

