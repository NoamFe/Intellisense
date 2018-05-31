# Intellisense
Simple intellisense code

Init the finder class like that:
```
   var classNames = new String[] {
                "GraphView",
                "DetailedDataView",
                "DataGraphView",
                "DataController",
                "GraphViewController",
                "MouseClickHandler",
                "MathCalculationHandler",
                "DataScienceView"
            };
            var finder = new Finder(classNames);
```

then call it like that:
```
var results = finder.Get("GV");             
```
