# Steps

1. [ ]  Database
    - [ ] Install SQL Express LocalDB on computer
        -  > Download Link https://www.microsoft.com/en-us/sql-server/sql-server-downloads
    - [ ] Install SQL Server Management Tools
        - > Download Link https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15
    - [ ] Check if SQL Express is working
        - > Simpy run SQL Server Management Studio and connect to random database
    - [ ] Connect SQL Express to Rider by local database
        - > Can't work with rider and SQL Express
        - > `Note!` There is a way to connect sql express with rider but it is too much configuration not necessary for this type of project
    - [ ] Install SQLLite on computer
        - > Download Link https://sqlite.org/download.html
    - [ ] Check how work with SQLite
        - [ ] Read Documentation
            - > Documentation Link https://sqlite.org/docs.html
        - [ ] Test working with SQLite
            - [ ] Create Folder to hold SQLite
                - > Folder Path `C:\sqlite`
            - [ ] Add programs form download to sqlite folder
                - > Program Names: `sqldiff.exe`, `sqlite3`, `sqlite3_analyzer`
            - [ ] Run SQLite by bash
                - > Run Command: `C:\sqlite>sqlite3` and output: `SQLite version 3.34.1 2021-01-20 14:10:07
                                                                  Enter ".help" for usage hints.
                                                                  Connected to a transient in-memory database.
                                                                  Use ".open FILENAME" to reopen on a persistent database.`
                
                    >Command Helper: <br>
                    `.archive ...           Manage SQL archives: ".archive --help" for details` <br>
                    `.auth ON|OFF           Show authorizer callbacks` <br>
                    `.backup ?DB? FILE      Backup DB (default "main") to FILE` <br>
                    `.bail on|off           Stop after hitting an error.  Default OFF` <br>
                    `.binary on|off         Turn binary output on or off.  Default OFF` <br>
                    `.cd DIRECTORY          Change the working directory to DIRECTORY` <br>
                    `.quit                  Stop instance of sqlite` <br>
            - [ ] Install SQLite GUI tool
                - > Download Link https://github.com/pawelsalawa/sqlitestudio/releases
                - > Install in directory `C:\sqlite\gui`
    - [ ] Create Database
        - [ ] Using SQLite GUI tool
            - > Database type `SQLite3`
            - > Database file `C:/sqlite/database/animalShelter.db`
            - > Database name `animalShelter`
    - [ ] Connect SQLite with Rider
         - > article reference https://www.jetbrains.com/help/rider/Connecting_to_a_database.html#connect-to-sqlite-database
    - [ ] Create mind map of database
        - > online tool reference https://app.diagrams.net/
        - > link to online mind map [Mind map online diagram](https://viewer.diagrams.net/?highlight=0000ff&edit=_blank&layers=1&nav=1&title=AnimalShelter#R7Z1bc%2BI2GIZ%2FDZfdARuDuVwgSbeTtDNJj1c7ChJGrbFcWRDYX18ZJE4fJPYWkCw8wwX%2BLITRI72WXx1o%2BIPp4oGjdPLEMIkbXhMvGv6w4Xmttuc18lcTL9eRbq%2B9DkScYpVoG3ih34gKNlV0RjHJ9hIKxmJB0%2F3giCUJGYm9GOKcve0nG7N4%2F1tTFBEQeBmhGEb%2FoFhM1tEwaG7jPxIaTfQ3t5rqzBTpxCqQTRBmbzsh%2F67hDzhjYv1uuhiQOC88XS7rz92fOLu5ME4SUeQDk8X02fenvS9f09HoJ9Ecf53NflC5zFE8Uz94yKJMXbBY6lKQ157mbwV6zUP9TCAuFCy%2FKQOy%2BAWiCeEy0FodxzFKM7pKvo5MaIwf0ZLNhM5IH%2FXHdEHw85pVnlZie5SZ5Yd55mOZ%2BYu6mPw0immUyPcj%2Bcvzb%2BxzkslreUSZUClg2egfSrggi52QKqsHwqZE8KVMos62FTZVbzua69u2FrRCFZvs1oCOCiJV86JN1ls48o3iU4KVB1id5CR%2FuaAofpYtAiXRCtk%2BkbxYMWfpr4hHRKhAymheoHdzWWqbsqdxPGAxy8EmLMlzEixVJ2My1p99ZUKwqeanimOT6aoogr58ycIZND8FjUBe7kAet7bH8pUn52LAkkxwWZ3yPIik%2BkZyskeovlunP0at2PoF0fqXIusDsimnU7S6xn%2FIshzmlQ6iLebSBJsHBA%2BbH5MlO45XUjahGJOkOBqvMJodFr1romgDFL8l9N8Z%2BTI0TEGL3jptP0vRiCbR4%2FqTnQNMwbUwLfYRmaIWVEIaD5FWQBo7pqWxA8hiFv2MpsRwcySY6vz%2BpyYGhZmYal1dwEDWQSk%2BtiviVaBYooBhrYCXUcAjYK%2BrgL1jCvg5ckcAw8JITDUubUbsKaDbAlgciiUC2IJWRq2AZ1HAlmdaAlvQ%2BqDZ5zmi8ao5uSKEreJojLUyaFW8MhYTlDishSW4WCKGHmwwg5iudKu2dj1fP9Va5O3CdmXj3cu8ubup2dVxdz3oKbpq7%2FqF4ezQuC4MaBXeosFbHNRiH9JuK2peFRx0Am1USPP9%2B%2FIKadzk9aDDmLhk8W7qrsW6CA1E503eElisUUHoBtYqeB4VNG706ox3m%2BCMuyWEvcJUTAmhD31E94WwOBZbhNCHDkcthOcRQvN%2Brw%2FdEIQ5yU67V1UTQr84FWNCCG0L54WwBBZrhBAaGr9wTHjt9OalfjCL1y%2Faybuc0%2BtXw8cw7%2FT6xefg2OL0%2BtDHcNTp9e13NHzoaNyg01sClDV3tNrjuJRCGnd629DjwCzKnsnYna69%2FR5HG3ocnIzt18XrULFFB9u1xXEpHTTu9bahwzFaT9BxSQo3NdhiKYQuhwLhtByWIGONHNaLvC4lh%2BYd3zZ0RaiUwozwOcHu6OF3rfW6LghoYbg%2FwbcEF2vUMAQ8CI6Idg2kikxYxBIU322jfc5mCSZYleg2zSNbochr999EiKUyhdFMMBmaiGmszspi5Ms%2FdbvID%2F7KDz4F%2BnC42D05XKojyEE9gWRsxkfknd%2BpZ6oJLdQf3dHyUniXICcxEnRO9q7j%2FHx6N8KnIB79%2FGUJngD6EPeMnb7T3NCYiZY21Tc4KnVHh0wut7q%2FGku7zA%2BZbGp1dYZMAmhyODpkEhRvica20YCuxA0OmZQAZclyrwCaGDYKpPlH4%2FICaXzEJIC2x0h2E4XhBnnG%2FU%2FahZkYa1%2FQnXB%2BKlQJLLaoILQuahU8jwoaHy8J4GQOpybGb%2BquxSIIp2W4L4LFsVgigh14q3pCEfpGk9ON5YbMDV%2BPdOiRD%2FPuRqcaty3z7kan%2BFQ2W9yNDrxtOepudL7rBnZdGPAGdoPuRglQtox1daFZb6NCmu%2FYl1dI4%2FZGF3r7Y8awS7OgusUft0xJYxe68K5PCC1BxRodrMYmUVXUQeMGRxda%2BHMWzyQNwp0SQ%2Fu3iOpCx915MazeflBd2Jv%2FXTeYk6RuyOk4mMbRahVUuMutfA2r0Y03b3RsqnZ1jI4QduMdNTpC%2B3vzIezN36DRUQKULfe0sO7gX0ohjRsdIezgOzWCGdrfsQ9hx975EcwSWKxRwWrskFJFFTRuc4RH%2FkvKsT0OQ%2Fu3RglvcLPXElisEcJ6I5RLCaH5Fa9aivdWvN6jOeNUOCSG9m%2BG0oPWhfsrXktwsUUN9R%2FHu76iUhf0h0sqtWlvyZLKXnAbfPTyoI%2F5NK%2FERx5yxsTOuQeO0skTwyRP8R8%3D "Link to mind map database")
    - [ ] Create sql table structure in SQLite GUI tool
        - [ ] Create table `Dogs`
            - > `CREATE TABLE Dogs (` <br> `    primaryKey  NUMERIC PRIMARY KEY NOT NULL,` <br> `   dogName     STRING  NOT NULL,` <br> `  dogAge      STRING  NOT NULL,` <br> ` isAvailable BOOLEAN NOT NULL` <br> `);`
            - > [Photo](https://imgur.com/a/LzZQmCE "Photo of table in SQLite GUI") of table `dogs` in GUI
        - [ ] Create table `Clients`
            - > `CREATE TABLE Clients (` <br> `primaryKey NUMERIC PRIMARY KEY NOT NULL,` <br> `name       STRING  NOT NULL,` <br> `name       STRING  NOT NULL,` <br> `adress     STRING  NOT NULL` <br> `);`
            - > [Photo](https://imgur.com/a/yQMfBet "Photo of table in SQLite GUI") of table `clients` in GUI
        - [ ] Create table `Orders`
            - > `CREATE TABLE Orders (` <br> `primaryKey NUMERIC PRIMARY KEY NOT NULL,` <br> `dogsRef    NUMERIC REFERENCES Dogs (primaryKey),` <br> `clientsRef NUMERIC REFERENCES Clients (primaryKey)` <br> `);`
            - > [Photo](https://imgur.com/a/YebirZJ "Photo of table in SQLite GUI") of table `orders` in GUI
        - [ ] Create table `Food`
            - > `CREATE TABLE Food (` <br> `primaryKey NUMERIC PRIMARY KEY NOT NULL,` <br> `count      STRING  NOT NULL,` <br> `name       STRING  NOT NULL` <br> `);`
            - > [Photo](https://imgur.com/a/dLAhki9 "Photo of table in SQLite GUI") of table `food` in GUI
        - [ ] Create table `Volunteer`
            - > `CREATE TABLE Volunteer (` <br> `primaryKey NUMERIC PRIMARY KEY NOT NULL,` <br> `name       STRING  NOT NULL,` <br> `surname    STRING  NOT NULL,` <br> `isFavorite BOOLEAN NOT NULL` <br> `);`
            - > [Photo](https://imgur.com/a/cNaFXef "Photo of table in SQLite GUI") of table `Volunteer` in GUI
        - [ ] Create table `Magazine`
            - > `CREATE TABLE Magazine (` <br> `primaryKey   NUMERIC PRIMARY KEY NOT NULL,` <br> `foodRef      NUMERIC REFERENCES Food (primaryKey),` <br> `volunteerRef NUMERIC REFERENCES Volunteer (primaryKey)` <br> `);`
            - > [Photo](https://imgur.com/a/y5B7ieL "Photo of table in SQLite GUI") of table `magazine` in GUI
    - [ ] Testing usability of database
        - [ ] Change primaryKey to autoincrement
            - [ ] Table `magazine`
                - > `PRAGMA foreign_keys = 0;` <br><br> `CREATE TABLE sqlitestudio_temp_table AS SELECT * FROM Magazine;` <br><br> `DROP TABLE Magazine;` <br><br> `CREATE TABLE Magazine (` <br> `primaryKey   INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,` <br> `foodRef      NUMERIC REFERENCES Food (primaryKey),` <br> `volunteerRef NUMERIC REFERENCES Volunteer (primaryKey) ` <br> `);` <br><br> `INSERT INTO Magazine (` <br> `primaryKey,` <br> ` foodRef,` <br> `volunteerRef` <br> `)` <br> ` SELECT primaryKey,` <br> `foodRef,` <br> `volunteerRef` <br> ` FROM sqlitestudio_temp_table;` <br><br> `DROP TABLE sqlitestudio_temp_table;` <br><br> `PRAGMA foreign_keys = 1;`
            - [ ] Table `orders`
                - > `PRAGMA foreign_keys = 0;` <br><br> `CREATE TABLE sqlitestudio_temp_table AS SELECT * FROM Orders;` <br><br> `DROP TABLE Orders;` <br><br> `CREATE TABLE Orders (` <br> `primaryKey INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,` <br> `dogsRef    NUMERIC REFERENCES Dogs (primaryKey),` <br> `clientsRef NUMERIC REFERENCES Clients (primaryKey)` <br> `);` <br><br> `INSERT INTO Orders (` <br> ` primaryKey,` <br> `dogsRef,` <br> `clientsRef` <br> `)` <br> `SELECT primaryKey,` <br> `dogsRef,` <br> `clientsRef` <br> ` FROM sqlitestudio_temp_table;` <br><br> `DROP TABLE sqlitestudio_temp_table;` <br> `PRAGMA foreign_keys = 1;`
            - [ ] Table `volunteer`
                - > `PRAGMA foreign_keys = 0;` <br><br> `CREATE TABLE sqlitestudio_temp_table AS SELECT * FROM Volunteer;` <br><br> `DROP TABLE Volunteer;` <br><br> `CREATE TABLE Volunteer (` <br> `primaryKey INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,` <br> `name       STRING  NOT NULL,` <br> `surname    STRING  NOT NULL,` <br> `isFavorite BOOLEAN NOT NULL` <br> `);` <br><br> `INSERT INTO Volunteer (` <br> `primaryKey,` <br> `name,` <br> `surname,` <br> `isFavorite` <br> `)` <br> `SELECT primaryKey,` <br> `name,` <br> `surname,` <br> `isFavorite` <br> `FROM sqlitestudio_temp_table;` <br> <br> `DROP TABLE sqlitestudio_temp_table;` <br> `PRAGMA foreign_keys = 1;`
            
    - [ ] Validating the correct display od tables in Rider
2. [ ] Entity Framework
3. [ ] Environment
4. [ ] Create views of application
5. [ ] Codding application mechanics
6. [ ] Unit Tests 
7. [ ] Application installer
8. [ ] Documentation
9. [ ] Finish
 
     