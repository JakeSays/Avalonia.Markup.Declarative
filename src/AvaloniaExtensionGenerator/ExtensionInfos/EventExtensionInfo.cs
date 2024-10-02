using AvaloniaExtensionGenerator.Generators;
using System.Reflection;

namespace AvaloniaExtensionGenerator.ExtensionInfos;

public class EventExtensionInfo : IMemberExtensionInfo
{
    public string MemberName { get; }
    public EventInfo EventInfo { get; }
    public Type ControlType { get; }
    public string EventHandler { get; }
    public string EventName { get; }
    public List<string> EventParameterTypes { get; } = new List<string>();
    public bool IsGeneric { get; }


    public EventExtensionInfo(EventInfo eventInfo)
    {
        if (eventInfo.DeclaringType == null)
            throw new NullReferenceException("Control type cannot be NULL");

        if (eventInfo.EventHandlerType == null)
            throw new NullReferenceException("Event handler type cannot be NULL");

        EventInfo = eventInfo;
        ControlType = eventInfo.DeclaringType;
        EventName = EventInfo.Name;
        MemberName = EventName;
        EventHandler = EventInfo.EventHandlerType.GetTypeDeclarationSourceCode();

        var methodInfo = eventInfo.EventHandlerType.GetMethod("Invoke");
        if (methodInfo != null)
        {
            foreach (var parameter in methodInfo.GetParameters())
            {
                EventParameterTypes.Add(parameter.ParameterType.GetTypeDeclarationSourceCode());
            }
        }

        IsGeneric = !eventInfo.DeclaringType.IsSealed;
    }

    public bool HasStandardSignature =>
        EventParameterTypes.Count == 2 && EventParameterTypes[0] == "System.Object" &&
        EventParameterTypes[1].EndsWith("EventArgs");

    public bool HasSingleParameter => EventParameterTypes.Count == 1;
    public bool HasMultipleParameters => EventParameterTypes.Count > 1;
}