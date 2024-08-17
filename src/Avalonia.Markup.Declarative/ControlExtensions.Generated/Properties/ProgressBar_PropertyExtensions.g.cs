#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using ProgressBar = Avalonia.Controls.ProgressBar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ProgressBarExtensions
{
public static T IsIndeterminate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);
public static T IsIndeterminate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, func, onChanged, expression);
public static T IsIndeterminate<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value, bindingMode, converter, bindingSource);
public static T IsIndeterminate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowProgressText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);
public static T ShowProgressText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowProgressText<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, func, onChanged, expression);
public static T ShowProgressText<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = value, bindingMode, converter, bindingSource);
public static T ShowProgressText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ProgressTextFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);
public static T ProgressTextFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ProgressTextFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, func, onChanged, expression);
public static T ProgressTextFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = value, bindingMode, converter, bindingSource);
public static T ProgressTextFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

