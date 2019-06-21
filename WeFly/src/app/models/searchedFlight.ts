export class searchedFlight{
    public routeId:string;
    public planType:string;
    public arrivalTimeSource:string;
    public departTimeSource:string;
    public arrivalTimeDestination:string;    
    public flightDuration:number;
    public noOfstops:number;
    public fromCity : string;
    public toCity : string;
    public fromCityCode : string;
    public fromCityName:string;
    public toCityCode : string;    
    public toCityName:string;
    public scheduleId:string;
    public flightPrice:number;
    public availableSeats:number;    
    public isMealAvailable:boolean;
    public airlineName:string;
    public airlineLogo:string;
    public planeId:string;
    public planeManufacturer:string;
    public planeModel:string;
    public seats: number;
    public legSpace:number;
    public isWifiAvailable:boolean;
    public isFlightEntertainmentAvailable:boolean;


    constructor(){
    }

}