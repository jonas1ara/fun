
open FSharp.Stats
open FSharp.Stats.Fitting.LinearRegression

let xData = vector [|1. .. 10.|]
let yData = vector [|4.;7.;9.;12.;15.;17.;16.;23.;5.;30.|]

//Least squares simple linear regression
let coefficientsLinearLS = 
    OrdinaryLeastSquares.Linear.Univariable.coefficient xData yData
let fittingFunctionLinearLS x = 
    OrdinaryLeastSquares.Linear.Univariable.fit coefficientsLinearLS x

//Robust simple linear regression
let coefficientsLinearRobust = 
    RobustRegression.Linear.theilSenEstimator xData yData 
let fittingFunctionLinearRobust x = 
    RobustRegression.Linear.fit coefficientsLinearRobust x

//least squares simple linear regression through the origin
let coefficientsLinearRTO = 
    OrdinaryLeastSquares.Linear.RTO.coefficientOfVector xData yData 
let fittingFunctionLinearRTO x = 
    OrdinaryLeastSquares.Linear.RTO.fit coefficientsLinearRTO x



let rawChart = 
    Chart.Point(xData,yData)
    |> Chart.withTraceName "raw data"
    
let fittingLS = 
    let fit = 
        [|0. .. 11.|] 
        |> Array.map (fun x -> x,fittingFunctionLinearLS x)
    Chart.Line(fit)
    |> Chart.withTraceName "least squares (LS)"

let fittingRobust = 
    let fit = 
        [|0. .. 11.|] 
        |> Array.map (fun x -> x,fittingFunctionLinearRobust x)
    Chart.Line(fit)
    |> Chart.withTraceName "TheilSen estimator"

let fittingRTO = 
    let fit = 
        [|0. .. 11.|] 
        |> Array.map (fun x -> x,fittingFunctionLinearRTO x)
    Chart.Line(fit)
    |> Chart.withTraceName "LS through origin"

let simpleLinearChart =
    [rawChart;fittingLS;fittingRTO;fittingRobust;] 
    |> Chart.combine
    |> Chart.withAxisTitles "" ""
