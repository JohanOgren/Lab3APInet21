# Lab3APInet21
Krav - 1 Hämta alla personer i systemet
-----------------------------------------------------------------------------------------------------------------------------------------
GET  https://localhost:44308/api/person

[
    {
        "personId": 1,
        "name": "Tony",
        "phoneNumber": "0701231233",
        "hobbies": null
    },
    {
        "personId": 2,
        "name": "Banner",
        "phoneNumber": "070321321",
        "hobbies": null
    },
    {
        "personId": 3,
        "name": "Rogers",
        "phoneNumber": "0703123123",
        "hobbies": null
    },
    {
        "personId": 4,
        "name": "Thor",
        "phoneNumber": "0704141444",
        "hobbies": null
    },
    {
        "personId": 5,
        "name": "Strange",
        "phoneNumber": "0705555112",
        "hobbies": null
    }
]

-----------------------------------------------------------------------------------------------------------------------------------------
Krav 2 Hämta alla intressen som är kopplade till en specifik person
GET  https://localhost:44308/api/person/1/hobbies
[
    {
        "hobbyId": 1,
        "titel": "Cars",
        "description": "Make them Shine",
        "personId": 1,
        "person": null,
        "webbLinks": null
    },
    {
        "hobbyId": 8,
        "titel": "Math",
        "description": "Calculate stuff",
        "personId": 1,
        "person": null,
        "webbLinks": null
    },
    {
        "hobbyId": 9,
        "titel": "Magic",
        "description": "Think i can fly",
        "personId": 1,
        "person": null,
        "webbLinks": null
    }
]
-----------------------------------------------------------------------------------------------------------------------------------------
Krav 3 Hämta alla länkar som är kopplade till en specifik person
GET https://localhost:44308/api/person/1/links
[
    {
        "webbLinkId": 1,
        "link": "FakeLinkForHobby1",
        "hobbyId": 1,
        "hobby": null
    },
    {
        "webbLinkId": 8,
        "link": "FakeLinkForHobby4",
        "hobbyId": 8,
        "hobby": null
    },
    {
        "webbLinkId": 9,
        "link": "FakeLinkForHobbyCanHeFly?",
        "hobbyId": 9,
        "hobby": null
    }
]
-----------------------------------------------------------------------------------------------------------------------------------------
Krav 4 Koppla en person till ett nytt intresse
POST  https://localhost:44308/api/person/1/createhobby


{
        "hobbyId": 1, <---------Tar bort denna innan jag trycker post för Tabellen skapar nytt ID av sig själv.
        "titel": "WorkOut",
        "description": "Train legs",
        "personId": 1,
        "person": null,
        "webbLinks": null
}
-----------------------------------------------------------------------------------------------------------------------------------------
Krav 5 Lägga in nya länkar för en specifik person och ett specifikt intresse
POST https://localhost:44308/api/person/1/links
{
    "webbLinkId": 1, <---------Tar bort denna innan jag trycker post för Tabellen skaopar nytt ID av sig själv.
    "link": "ThisIsAhNewLink",
    "hobbyId": 1,
    "hobby": null
}
