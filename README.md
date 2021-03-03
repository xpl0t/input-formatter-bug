# SystemTextJsonInputFormatter bug reproduction

## How to reproduce

Open a command line in the repository folder and type `dotnet restore`, then `dotnet run`.

Now with the api successfully running, send the following POST request to it:

```
POST http://localhost:5000/test

{
  "name": "Test",
  "email": "nomailhere"
}
```

Curl command

```
curl --request POST --url http://localhost:5000/test --header 'Content-Type: application/json' --data '{ "name": "Test", "email": "nomailhere" }' --silent
```

The expected result is a string with the value "nomailhere", because the failing modelStateEntry is returned directly, however the result ist **204 No Content**, because the **RawValue**/**AttemptedValue** properties of the relevant modelStateEntry is not filled.