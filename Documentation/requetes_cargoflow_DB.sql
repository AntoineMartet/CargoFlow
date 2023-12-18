INSERT INTO articles (barcode,model,brand,weight,height,lenght,width,price,category_id) VALUES ('123456789012','Galaxy S21','Samsung','0.2','15','7.5','0.8','1099.9','1')
INSERT INTO articles (barcode,model,brand,weight,height,lenght,width,price,category_id) VALUES ('987654321098','Slim Fit Jeans','Levi's','0.7','110','50','0.5','79.9','2')
INSERT INTO articles (barcode,model,brand,weight,height,lenght,width,price,category_id) VALUES ('567890123456','Ektorp Sofa','IKEA','25','80','200','100','999.9','3')
INSERT INTO articles (barcode,model,brand,weight,height,lenght,width,price,category_id) VALUES ('345678901234','Air Zoom Pegasus','Nike','0.5','12','30','10','129.9','4')
INSERT INTO articles (barcode,model,brand,weight,height,lenght,width,price,category_id) VALUES ('789012345678','Kindle Oasis','Amazon','0.3','20','15','1','199.9','5')



INSERT INTO carriers (companyName,loadCapacity,email,phoneNumber) VALUES ('FedEx','500','contact@fedex.com','0041581234567')
INSERT INTO carriers (companyName,loadCapacity,email,phoneNumber) VALUES ('UPS','80','contact@ups.com','0041241234567')
INSERT INTO carriers (companyName,loadCapacity,email,phoneNumber) VALUES ('DHL','1600','contact@dhl.com','0041211234567')
INSERT INTO carriers (companyName,loadCapacity,email,phoneNumber) VALUES ('DPD','750','contact@dpd.com','0041221234567')
INSERT INTO carriers (companyName,loadCapacity,email,phoneNumber) VALUES ('Planzer','900','contact@planzer.com','0041911234567')



INSERT INTO categories (name,description) VALUES ('Électronique','Produits technologiques de pointe')
INSERT INTO categories (name,description) VALUES ('Vêtements','Vêtements élégants et confortables')
INSERT INTO categories (name,description) VALUES ('Maison et Jardin','Articles de qualité pour la maison et les espaces extérieurs')
INSERT INTO categories (name,description) VALUES ('Équipement Sport','Équipement et accessoires pour divers sports')
INSERT INTO categories (name,description) VALUES ('Livres','Lectures captivantes pour tous les goûts')



INSERT INTO clients (lastName,firstName,email,street,streetNumber,city,postalCode) VALUES ('Dupont','Marie','marie.dupont@email.com','Rue de la Paix','12','Paris','75001')
INSERT INTO clients (lastName,firstName,email,street,streetNumber,city,postalCode) VALUES ('Tremblay','Jean','jean.tremblay@email.com','Avenue des Lilas','34','Montréal','H2B 2X9')
INSERT INTO clients (lastName,firstName,email,street,streetNumber,city,postalCode) VALUES ('Silva','Ana','ana.silva@email.com','Rua Augusta','45','Lisbonne','1000-050')
INSERT INTO clients (lastName,firstName,email,street,streetNumber,city,postalCode) VALUES ('Müller','Stefan','stefan.muller@email.com','Goethestraße','67','Berlin','10117')
INSERT INTO clients (lastName,firstName,email,street,streetNumber,city,postalCode) VALUES ('Bianchi','Chiara','chiara.bianchi@email.com','Via della Moscova','89','Milan','20121')



INSERT INTO days (name) VALUES ('Lundi')
INSERT INTO days (name) VALUES ('Mardi')
INSERT INTO days (name) VALUES ('Mercredi')
INSERT INTO days (name) VALUES ('Jeudi')
INSERT INTO days (name) VALUES ('Vendredi')



INSERT INTO deliveries (barcode,startDate,endDate,status,carrier_id,client_id,warehouse_origin_id,warehouse_destination_id) VALUES ('123456789012','2023-02-15 10:00:00','2023-02-18 14:30:00','Livré','1','1','1','null')
INSERT INTO deliveries (barcode,startDate,endDate,status,carrier_id,client_id,warehouse_origin_id,warehouse_destination_id) VALUES ('987654321098','2023-02-16 08:45:00','2023-02-17 11:15:00','En transit','2','null','2','3')
INSERT INTO deliveries (barcode,startDate,endDate,status,carrier_id,client_id,warehouse_origin_id,warehouse_destination_id) VALUES ('567890123456','2023-02-17 14:20:00','2023-02-18 18:45:00','Planifié','3','null','3','5')
INSERT INTO deliveries (barcode,startDate,endDate,status,carrier_id,client_id,warehouse_origin_id,warehouse_destination_id) VALUES ('345678901234','2023-02-18 11:30:00','2023-03-01 16:00:00','En transit','4','5','4','null')
INSERT INTO deliveries (barcode,startDate,endDate,status,carrier_id,client_id,warehouse_origin_id,warehouse_destination_id) VALUES ('789012345678','2023-02-19 09:15:00','2023-02-26 12:45:00','Livré','5','2','5','null')



INSERT INTO deliveries_have_articles (delivery_id,article_id,quantity) VALUES ('1','1','32')
INSERT INTO deliveries_have_articles (delivery_id,article_id,quantity) VALUES ('2','1','15')
INSERT INTO deliveries_have_articles (delivery_id,article_id,quantity) VALUES ('3','2','67')
INSERT INTO deliveries_have_articles (delivery_id,article_id,quantity) VALUES ('4','5','36')
INSERT INTO deliveries_have_articles (delivery_id,article_id,quantity) VALUES ('5','5','103')



INSERT INTO employees (lastName,firstName,password,email,phoneNumber,role,employeeNumber,) VALUES ('Martin','Pierre','pmartin','pierre.martin@email.com','0041589876543','Gestionnaire','E1001','')
INSERT INTO employees (lastName,firstName,password,email,phoneNumber,role,employeeNumber,) VALUES ('Favre','Marie','mfavre','marie.favre@email.com','0041249876543','Logistique','E1002','')
INSERT INTO employees (lastName,firstName,password,email,phoneNumber,role,employeeNumber,) VALUES ('Lefevre','Olivia','olefevre','olivia.lefevre@email.com','0041219876543','ServiceClient','E1003','')
INSERT INTO employees (lastName,firstName,password,email,phoneNumber,role,employeeNumber,) VALUES ('Leroux','Isabelle','ileroux','isabelle.leroux@email.com','0041229876543','Développeur','E1004','')
INSERT INTO employees (lastName,firstName,password,email,phoneNumber,role,employeeNumber,) VALUES ('Moreau','Nicolas','nmoreau','nicolas.moreau@email.com','0041919876543','Marketing','E1005','')



INSERT INTO warehouses (name,street,streetNb,city,postalCode) VALUES ('StockExpress','Rue de la Logistique','22','Paris','75001')
INSERT INTO warehouses (name,street,streetNb,city,postalCode) VALUES ('LogiStock','Avenue des Entrepôts','45','Lyon','69002')
INSERT INTO warehouses (name,street,streetNb,city,postalCode) VALUES ('MagazzinoItaliano','Via Magazzino','78','Milan','20123')
INSERT INTO warehouses (name,street,streetNb,city,postalCode) VALUES ('Lagerhaus','Am Lagerplatz','34','Berlin','10115')
INSERT INTO warehouses (name,street,streetNb,city,postalCode) VALUES ('AlmacenCentral','Calle de Almacén','56','Barcelone','8001')



INSERT INTO warehouses_have_articles (article_id,warehouse_id,quantity) VALUES ('1','2','6')
INSERT INTO warehouses_have_articles (article_id,warehouse_id,quantity) VALUES ('2','2','425')
INSERT INTO warehouses_have_articles (article_id,warehouse_id,quantity) VALUES ('3','4','87')
INSERT INTO warehouses_have_articles (article_id,warehouse_id,quantity) VALUES ('4','5','23')
INSERT INTO warehouses_have_articles (article_id,warehouse_id,quantity) VALUES ('5','5','45')



INSERT INTO warehouses_have_employees (warehouse_id,employees_id) VALUES ('1','1')
INSERT INTO warehouses_have_employees (warehouse_id,employees_id) VALUES ('1','2')
INSERT INTO warehouses_have_employees (warehouse_id,employees_id) VALUES ('1','3')
INSERT INTO warehouses_have_employees (warehouse_id,employees_id) VALUES ('3','4')
INSERT INTO warehouses_have_employees (warehouse_id,employees_id) VALUES ('4','5')



INSERT INTO warehouses_have_days (warehouse_id,day_id,closingHours,closingHours) VALUES ('1','1',' 09:00','18:00')
INSERT INTO warehouses_have_days (warehouse_id,day_id,closingHours,closingHours) VALUES ('2','2',' 08:30','17:30')
INSERT INTO warehouses_have_days (warehouse_id,day_id,closingHours,closingHours) VALUES ('3','3',' 10:00','19:00')
INSERT INTO warehouses_have_days (warehouse_id,day_id,closingHours,closingHours) VALUES ('4','4',' 08:00','16:45')
INSERT INTO warehouses_have_days (warehouse_id,day_id,closingHours,closingHours) VALUES ('5','5',' 09:30','18:30')
