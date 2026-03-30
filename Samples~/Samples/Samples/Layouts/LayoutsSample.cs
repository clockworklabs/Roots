using RishUI;
using RishUI.MemoryManagement;
using Roots;
using Roots.Rootstrap;

namespace RootsSamples
{

    public partial class LayoutsSample : ISample
    {
        int ISample.Order => 6;
        string ISample.Name => "Layouts";
        string ISample.Icon => FontAwesome.FA_TableColumns.Unicode;

        Element ISample.Factory() => ResponsiveContext.Create(
            children: Col.Create(
                gap: 16,
                children: new()
                {
                    Grid.Create(
                        key: 1,
                        xsGutter: 4,
                        mdGutter: 8,
                        cols: new()
                        {
                            new ColData(),
                            new ColData(),
                            new ColData(),
                        }),
                    Grid.Create(
                        key: 2,
                        xs: 1,
                        sm: 3,
                        md: 7,
                        xsGutter: 4,
                        mdGutter: 8,
                        cols: new()
                        {
                            new ColData
                            {
                                md = 2,
                                lg = 1,
                            },
                            new ColData
                            {
                                md = 2,
                                lg = 5
                            },
                            new ColData
                            {
                                md = 3,
                                lg = 1,
                            },
                        }),
                    Col.Create(
                        gap: 8,
                        separator: Icon.Create(className: "align-self-center", unicode: FontAwesome.FA_Circle.Unicode),
                        children: new Children
                        {
                            Unit.Create(),
                            Unit.Create(),
                            Small.Create(className: "position-absolute", text: "Absolute positioned. Ignored by the column."),
                            Unit.Create(),
                            Col.Create(
                                gap: 4,
                                children: new Children
                                {
                                    Unit.Create(),
                                    Row.Create(
                                        gap: 4,
                                        children: new Children
                                        {
                                            Unit.Create(),
                                            Unit.Create()
                                        }),
                                    Unit.Create(),
                                    Unit.Create(),
                                }),
                            Unit.Create(),
                            Unit.Create()
                        })
                }));
    }
}