#Task 2
#Query 1
Select hotelNo, type, price from Room where type='Deluxe' OR type='Double' AND price >99;
#Query 2
Select hotelNo, COUNT(*) From Room where type='Double' Group by hotelNo HAVING count(*)>2;
#Query 3
Select COUNT(DISTINCT guestNo) From Booking where hotelNo=(Select hotelNo From Hotel where hotelName='Ridge Hotel');
#Query 4
Select a. DATEDIFF(day, dateTo, dateFrom) AS DIFF, a. roomNo, a. hotelNo, b.price, SUM(a. DIFF*b. price) From Booking a JOIN Room b ON a. hotelNo= b. hotelNo WHERE hotelNo=(Select hotelNo From Hotel where hotelName='Grosvenor Hotel');
#Query 5
UPDATE Room SET price = price*1.20 Where type='Deluxe';
#Query 6
Select guestNo from Guest JOIN Hotel where guestAddress=city;
#Task 3
#Insert
INSERT INTO Hotel (hotelNo, hotelName, city) VALUES ('H8', 'W Hotel', 'Brisbane');
INSERT INTO Room (roomNo, hotelNo, type, price) VALUES ('R1', 'H8', 'Deluxe', 400);
INSERT INTO Booking (hotelNo, guestNo, dateFrom, dateTo, roomNo) VALUES ('H8','G9','2008-01-01','2010-01-01','R1');
INSERT INTO Guest (guestNo, guestName, guestAddress) VALUES ('R1', 'Howard', 'Brisbane');
#Delete
DELETE FROM Guest WHERE guestNo='R1';
#Update
UPDATE Room SET price = price*1.10;
#Task 4
#Create index
CREATE INDEX guestName ON Guest(guestNo, guestAddress);
#Create view
CREATE VIEW Combined_list AS
   SELECT a.staffNo, a.fName, b. propertyNo, b. rent, b. ownerNo 
    FROM Staff a
    JOIN PropertyForRent b ON a.branchNo = b.branchNo;
#Task 5
#Nikki must be able to add records to the Booking table
GRANT INSERT ON Booking TO nikki;
#Nikki must be able to remove record from the Booking table
GRANT DELETE ON Booking TO nikki;
#Phil is no longer allowed to add data to the Guest table
REVOKE INSERT ON Guest FROM phil;
#Phil is no longer allowed to delete records from the Guest table
REVOKE DELETE ON Guest FROM phil;




