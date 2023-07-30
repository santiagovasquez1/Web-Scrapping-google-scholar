IEnumerable<UiElement> parentElements = ...

foreach (UiElement parentElement in parentElements)
{
    // Usa la actividad 'Get Attribute' para obtener el parentid del elemento actual.
    // Asegúrate de cambiar "Attribute Name" por "aaname", "id", "name", "class", etc. dependiendo de cómo se identifica tu elemento.
    var getParentId = new GetAttribute
    {
        Element = parentElement,
        Attribute = "id",
        Result = new OutArgument<string>(parentId)
    };
    context.ScheduleActivity(getParentId);

    // Construye el selector utilizando el parentId.
    string selector = "<webctrl parentid='" + parentId + "' tag='A' aria-role='button' />"

    // Usa la actividad 'Click' con el selector dinámico.
    Click activity with the selector
}