#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using NumericUpDown = Avalonia.Controls.NumericUpDown;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NumericUpDownExtensions
{
public static T AllowSpin<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);
public static T AllowSpin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowSpin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, func, onChanged, expression);
public static T AllowSpin<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static T AllowSpin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static T ButtonSpinnerLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func, Action<Avalonia.Controls.Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, func, onChanged, expression);
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);
public static T ShowButtonSpinner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, func, onChanged, expression);
public static T ShowButtonSpinner<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ClipValueToMinMax<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);
public static T ClipValueToMinMax<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClipValueToMinMax<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, func, onChanged, expression);
public static T ClipValueToMinMax<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = value, bindingMode, converter, bindingSource);
public static T ClipValueToMinMax<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T NumberFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);
public static T NumberFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T NumberFormat<T>(this T control, Func<System.Globalization.NumberFormatInfo> func, Action<System.Globalization.NumberFormatInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, func, onChanged, expression);
public static T NumberFormat<T>(this T control, System.Globalization.NumberFormatInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = value, bindingMode, converter, bindingSource);
public static T NumberFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.NumberFormatInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FormatString<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);
public static T FormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, func, onChanged, expression);
public static T FormatString<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.FormatStringProperty, ps, () => control.FormatString = value, bindingMode, converter, bindingSource);
public static T FormatString<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.FormatStringProperty, ps, () => control.FormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Increment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);
public static T Increment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Increment<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, func, onChanged, expression);
public static T Increment<T>(this T control, System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.IncrementProperty, ps, () => control.Increment = value, bindingMode, converter, bindingSource);
public static T Increment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.IncrementProperty, ps, () => control.Increment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsReadOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, func, onChanged, expression);
public static T IsReadOnly<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static T IsReadOnly<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Maximum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, func, onChanged, expression);
public static T Maximum<T>(this T control, System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static T Maximum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Minimum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, func, onChanged, expression);
public static T Minimum<T>(this T control, System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static T Minimum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ParsingNumberStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);
public static T ParsingNumberStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ParsingNumberStyle<T>(this T control, Func<System.Globalization.NumberStyles> func, Action<System.Globalization.NumberStyles>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, func, onChanged, expression);
public static T ParsingNumberStyle<T>(this T control, System.Globalization.NumberStyles value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = value, bindingMode, converter, bindingSource);
public static T ParsingNumberStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.NumberStyles> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextConverter<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);
public static T TextConverter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextConverter<T>(this T control, Func<Avalonia.Data.Converters.IValueConverter> func, Action<Avalonia.Data.Converters.IValueConverter>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, func, onChanged, expression);
public static T TextConverter<T>(this T control, Avalonia.Data.Converters.IValueConverter value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = value, bindingMode, converter, bindingSource);
public static T TextConverter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.Converters.IValueConverter> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, binding);
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Value<T>(this T control, Func<System.Nullable<System.Decimal>> func, Action<System.Nullable<System.Decimal>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, func, onChanged, expression);
public static T Value<T>(this T control, System.Nullable<System.Decimal> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static T Value<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Decimal>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, func, onChanged, expression);
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static T TextAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, func, onChanged, expression);
public static T InnerLeftContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static T InnerLeftContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, func, onChanged, expression);
public static T InnerRightContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static T InnerRightContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

