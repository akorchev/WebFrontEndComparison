using CSharpSharedData;
using Dnet.Blazor.Components.Grid.BlgGrid;
using Dnet.Blazor.Components.Grid.Infrastructure.Entities;
using Dnet.Blazor.Components.Grid.Infrastructure.Enums;
using Dnet.Blazor.Infrastructure.Models.SearchModels;
using System;
using System.Linq;
using System.Net.Http.Json;

namespace BlazorWasmAppDnetBlazor.Pages;

public partial class FetchData
{
    private BlgGrid<WeatherForecast> _blGridReference;

    public List<GridColumn<WeatherForecast>> _gridColumns { get; set; }

    public GridColumn<WeatherForecast> _groupGridColumn { get; set; }

    public GridOptions<WeatherForecast> _gridOptions { get; set; }

    private WeatherForecast[]? forecasts;

    protected override void OnInitialized()
    {
        _gridOptions = GetGridOptions();

        _gridColumns = GetGridColumns();

        _groupGridColumn = GetGroupGridColumn();

        forecasts = WeatherForecast.Data;

        _gridOptions.NumberOfRows = forecasts.ToList().Count;
    }

    private GridOptions<WeatherForecast> GetGridOptions()
    {
        return new GridOptions<WeatherForecast>()
        {
            HeaderHeight = 60,
            RowHeight = 40,
            PaginationPageSize = WeatherForecast.Data.Length,
            GridClass = "cvs-bl-grid",
            EnableGrouping = true, // Enable Grouping
            GroupDefaultExpanded = true,
            NullValueSortedToEnd = true,
            UseVirtualization = true,
            Pagination = false,
            SuppressPaginationPanel = true,
        };
    }

    private GridColumn<WeatherForecast> GetGroupGridColumn()
    {
        return new GridColumn<WeatherForecast>()
        {
            Height = 40,
            Width = 200,
            CanGrow = 0
        };
    }

    private List<GridColumn<WeatherForecast>> GetGridColumns()
    {
        var height = 40;
        var width = 200;
        var canGrow = 1;

        return new List<GridColumn<WeatherForecast>> {
                        new GridColumn<WeatherForecast> {
                            ColumnId = 0,
                            ColumnOrder = 0,
                            HeaderName = "LastRendered",
                            DataField = "LastRendered",
                            Width= 150,
                            Height= height,
                            CanGrow = canGrow,
                            CellDataFn = (x) => x.RowData.LastRendered,
                            CellDataType = CellDataType.Number,
                            AlingContent = AlingContent.Center,
                           
                        },
                        new GridColumn<WeatherForecast> {
                            ColumnId = 1,
                            ColumnOrder = 1,
                            HeaderName = "Date",
                            DataField = "Date",
                            Width= width,
                            Height= height,
                            CanGrow = canGrow,
                            CellDataFn = (x) => x.RowData.Date,
                            CellDataType = CellDataType.Date,
                            AlingContent = AlingContent.Center,
                            ShowGroupingButtons = true,
                        },
                        new GridColumn<WeatherForecast> {
                            ColumnId = 2,
                            ColumnOrder = 2,
                            HeaderName = "TemperatureC",
                            DataField = "TemperatureC",
                            Width= width,
                            Height= height,
                            CanGrow = canGrow,
                            CellDataFn = (x) => x.RowData.TemperatureC,
                            CellDataType = CellDataType.Number,
                        },
                        new GridColumn<WeatherForecast> {
                            ColumnId = 3,
                            ColumnOrder = 3,
                            HeaderName = "TemperatureF",
                            DataField = "TemperatureF",
                            Width= width,
                            Height= height,
                            CanGrow = canGrow,
                            CellDataFn = (x) => x.RowData.TemperatureF,
                            CellDataType = CellDataType.Number,
                        },
                        new GridColumn<WeatherForecast> {
                            ColumnId = 4,
                            ColumnOrder = 4,
                            HeaderName = "Summary",
                            DataField = "Summary",
                            Width= width,
                            Height= height,
                            CanGrow = canGrow,
                            CellDataFn = (x) => x.RowData.Summary,
                            CellDataType = CellDataType.Text,
                            //RowGroupIndex = 0, //Is set, blgrid group by this column in start up. Is not set you can dinamically group by this column
                            RowGroup = true, //Enable grouping
                            ShowGroupingButtons = true, //Hide-Show Grouping buttons
                        },

        };
    }
}