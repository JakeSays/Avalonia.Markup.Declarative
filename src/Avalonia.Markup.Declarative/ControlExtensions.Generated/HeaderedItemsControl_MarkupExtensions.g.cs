#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class HeaderedItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // Header

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Header<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Header<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HeaderTemplate

/*BindFromExpressionSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HeaderTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
   => control._set(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HeaderTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> control._setEx(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, binding);


 // HeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, binding);



}
