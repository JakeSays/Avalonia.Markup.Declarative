#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DataValidationErrors = Avalonia.Controls.DataValidationErrors;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DataValidationErrorsExtensions
{
public static T ErrorTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);
public static T ErrorTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ErrorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, func, onChanged, expression);
public static T ErrorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value, bindingMode, converter, bindingSource);
public static T ErrorTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Owner<T>(this T control, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, binding);
public static T Owner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Owner<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, func, onChanged, expression);
public static T Owner<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.OwnerProperty, ps, () => control.Owner = value, bindingMode, converter, bindingSource);
public static T Owner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.OwnerProperty, ps, () => control.Owner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

