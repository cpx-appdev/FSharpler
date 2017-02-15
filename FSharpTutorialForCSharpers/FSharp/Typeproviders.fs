namespace FSharp

open System.Data.Linq
open FSharp.Data.TypeProviders
open FSharp.Data

module TypeProviders =
//    type dbSchema = SqlDataConnection<"Data Source=.;Initial Catalog=FSharpDB;Integrated Security=True">
//    let db = dbSchema.GetDataContext()
//
//    let getPersonsFromDb =
//        query {
//            for person in db.Persons do
//                yield person.Firstname, person.Lastname            
//        }


      type jsonSchema = JsonProvider<"./Testdata.json">
      let valuesFromJson = jsonSchema.Load("./Testdata.json");
      let getPersonsFromJson =
        seq {
            for person in valuesFromJson do
                yield person.Firstname, person.Lastname
        }