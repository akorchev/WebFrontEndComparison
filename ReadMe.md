# Purpose

To evaluate the speed of data grids rendering grouped data.  I use the exact same data
consisting of 500 rows of weatherforecasts, and then create a grouped grid for each
Blazor component suite I can find.

I have used `N/A` for the `Group` column where the library automatically collapses
after grouping, as this would be an unfair metric considering the other
libraries expand by default and therefore have more work to do.

## Note
I have sinus problems, so there will be coughing and snorting in the videos.

## Results
|Library|Virtualization|Initial display|Group|Expand/Collapse|Video|Website|
|-------|----------------------|----------------|---------------|-----|
|Blazor-ComponentOne|Yes|5.5 seconds|2 seconds|0.5 seconds|[YouTube](https://youtu.be/C1ULsOueD_g)|[GrapeCity.com](https://www.grapecity.com/componentone/blazor-ui-controls)|
|Blazor-DevExpress|No|11 seconds|2.5 seconds|12 seconds|[YouTube](https://youtu.be/tXgz-pLyC-c)|[DevExpress.com](https://www.devexpress.com/blazor/)|
|Blazor-Dalnet|Yes|0.5 seconds|instant|instant|[YouTube](https://youtu.be/LwThq6_zJmM)|[DalNet](https://datalnet.com)|
|Blazor-MudBlazor|Yes|3.5 seconds|instant|2.5 seconds|[YouTube](https://youtu.be/U7RV1Edyzh8)|[MudBlazor.com](https://mudblazor.com/)|
|Blazor-Radzen|Yes|7.5 seconds|6 seconds|3 secondss|[YouTube](https://youtu.be/ebVdUVubjts)|[Radzen.com](https://blazor.radzen.com/)|
|Blazor-Syncfusion|Yes|2 seconds|1.5 seconds|instants|[YouTube](https://youtu.be/jDbKjoB4KYE)|[Syncfusion.com](https://www.syncfusion.com/)|
|Blazor-Telerik|No|6 seconds|10 seconds|6 seconds|[YouTube](https://youtu.be/2wBSGboTkDw)|[Telerik.com](https://www.telerik.com/)|