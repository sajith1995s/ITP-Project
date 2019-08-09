----------------------------------------------------------------------------wish DATA -4



INSERT INTO employee VALUES( 'E0001','Conrad', 'Baumann', '1999-12-10', 'Male', 'Katuwawala','Maharagama', 'gampaha', '970079955V', '0771165494', 'Head Technician',3659874,'2017-10-11','11:00','available')
INSERT INTO employee VALUES( 'E0002','Morgan', 'Renteria', '1983-07-23', 'Male', 'Horana','Colombo', 'Colombo', '913394314V', '0112480473', N'Senior Technician',0569840,'2017-10-11','11:00','unavailable')
INSERT INTO employee VALUES('E0003','Micheal', 'Neeley', '1983-01-15', 'Male', 'Galle','Seeduwa', 'Galle', '977879955V', '0789036769', 'Head Technician',2165987,'2017-10-11','11:00','available')
INSERT INTO employee VALUES('E0004','Adam', 'Reyes', '1986-07-21', 'Female', 'Hokandara','Kudamaduwa', N'Raymond Terrace', '878579955V', '0757294206', N'Clerk',92514360,'2017-10-11','11:00','unavailable')
INSERT INTO employee VALUES('E0005','Kittie', 'Mathews', '1972-12-07', 'Male', 'Kottawa','Pitipana', 'Kottawa', '568579955V', '0112250832', N'Junior Technician',4598763,'2017-10-11','11:00','available')
INSERT INTO employee VALUES('E0006','Stefani', 'Keenan', '2000-08-25', 'Female', 'Moratuwa','Kothalawala', 'Moratuwa','868579955V', '0766315532', N'Clerk',0456987,'2017-10-11','11:00','available')
INSERT INTO employee VALUES('E0007','Madelene', 'Neely', '1982-06-20', 'Female', 'Homagama','Waththala', 'Waththala', '953394314V', '0779212095', N'Senior Technician',9102365,'2017-10-11','11:00','available')
INSERT INTO employee VALUES('E0008','Ramiro', 'Galindo', '2016-07-06', 'Male', 'Dikwalla','Matara', 'Matara', '668579955V', '0760811355', N'Senior Technician',9123456,'2017-10-11','11:00','unavailable')
INSERT INTO employee VALUES('E0009','Abraham', 'Cary', '2011-06-11', 'Male', 'Pittugala','Malabe', 'Malabe', N'918694314V', '0781226182', N'Junior Technician',9253614,'2017-10-11','11:00','available')
INSERT INTO employee VALUES('E0010','Amos', 'Reyna', '2014-10-07', 'Male', 'Kottawa','Pitipana', 'Kottawa', N'618964314V', '0778001451', N'Junior Technician', 1236548,'2017-10-11','11:00','available')


INSERT employee_work_hours_and_rate VALUES('E0001',4,3,100,200,3659874)
INSERT employee_work_hours_and_rate VALUES( 'E0002',6,9,150,300,0569840)
INSERT employee_work_hours_and_rate VALUES( 'E0003',9,4,100,300,2165987)
INSERT employee_work_hours_and_rate VALUES( 'E0004',8,6,200,400,92514360)
INSERT employee_work_hours_and_rate VALUES( 'E0005',4,7,100,200,4598763)
INSERT employee_work_hours_and_rate VALUES( 'E0006',21,12,120,240,0456987)
INSERT employee_work_hours_and_rate VALUES('E0007',6,9,100,200,9102365)
INSERT employee_work_hours_and_rate VALUES( 'E0008',7,8, 200,400,9123456)
INSERT employee_work_hours_and_rate VALUES( 'E0009',9,8, 300, 600,9253614)
INSERT employee_work_hours_and_rate VALUES( 'E0010',7,8, 150, 200,1236548)


INSERT emp_attendance VALUES('EA0001', 'E0001','2017-09-18',' 00:23:28','07:44:27',3659874)
INSERT emp_attendance VALUES( 'EA0002','E0002',  '2017-09-09','13:06:51', '11:04:36',0569840)
INSERT emp_attendance VALUES( 'EA0003','E0003',  '2017-08-08','20:14:32', '09:14:07',2165987)
INSERT emp_attendance VALUES( 'EA0004','E0004',  '2017-08-22','05:56:37', '04:49:01',92514360)
INSERT emp_attendance VALUES( 'EA0005','E0005',  '2017-08-22','07:05:53', '17:12:49',4598763)
INSERT emp_attendance VALUES( 'EA0006','E0006',  '2017-08-23','20:59:31', '04:37:11',0456987)
INSERT emp_attendance VALUES('EA0007','E0007',  '2017-08-29','22:23:04', '19:59:09',9102365)
INSERT emp_attendance VALUES( 'EA0008','E0008',  '2017-08-14','01:25:35', '09:59:23',9123456)
INSERT emp_attendance VALUES( 'EA0009','E0009',  '2017-09-22','02:21:40', '13:24:38',9253614)
INSERT emp_attendance VALUES( 'EA0010','E0010',  '2017-08-21 ','08:56:27', '20:01:37',1236548)

INSERT emp_salary VALUES( 'ES0001','E0010', 'EA0001', 9.00, 138.00, 7, 3,'2017-04-09' ,51663.00)
INSERT emp_salary VALUES( 'ES0002','E0004', 'EA0002', 46.00, 84.00, 6, 1, '2016-03-10',36302.00)
INSERT emp_salary VALUES( 'ES0003','E0001','EA0003',  28.00, 104.00, 0, 3, '2015-05-19',68725.00)
INSERT emp_salary VALUES( 'ES0004','E0003','EA0003',  42.00, 48.00, 9, 1,'2016-08-26' ,60669.00)
INSERT emp_salary VALUES( 'ES0005','E0008','EA0004',  11.00, 66.00, 7, 2,'2017-09-12' ,48333.00)
INSERT emp_salary VALUES( 'ES0006','E0005','EA0005',  21.00, 135.00, 4, 3,'2017-10-11' ,64284.00)
INSERT emp_salary VALUES( 'ES0007','E0007','EA0006',  82.00, 31.00, 5, 0, '2016-12-09',59730.00)
INSERT emp_salary VALUES( 'ES0008','E0009','EA0007',  78.00, 149.00, 3, 0, '2017-08-30',52431.00)
INSERT emp_salary VALUES('ES0009', 'E0006','EA0009',  83.00, 135.00, 3, 4, '2017-09-04',37147.00)
INSERT emp_salary VALUES('ES0010', 'E0002','EA0010',  41.00, 41.00, 5, 0, '2017-04-01',25418.00)
-------------------------------------------sachin DATA -1

INSERT INTO customers VALUES('C0001','Sajith','Priyankara','951285612V','0775248536','cross lane','Diwurampitiya','Awissawella','sajith1995@gmail.com')
INSERT INTO customers VALUES('C0002','Sameer','Hilmi','975642580V','0777409647','1st lane','Bambalapitiya','Colombo','sameerH@gmail.com')
INSERT INTO customers VALUES('C0003','Sachin','Lahiru','953391880V','0772685129','canal road','Danduyaya','Galewela','sachin.lahiru@gmail.com')
INSERT INTO customers VALUES('C0004','Shaleendra','Thusitha','913395678V','077596456','Cross lane','Diwurampitiya','Awissawella','tshaleendra@gmail.com')
INSERT INTO customers VALUES('C0005','Tharindu','Jayakody','958742154V','077125498','2nd lane','Dambagolla','Nittambuwa','tharinduT@gmail.com')
INSERT INTO customers VALUES('C0006','Thilina','Karunarathna','953395645V','0775278556','3rd lane','Isuru uyana','Galewela','thilina5@gmail.com')
INSERT INTO customers VALUES('C0007','Sandun','Karunathilaka','956541285V','0712569875','Hospital road','Madipola','Matale','sandunK@gmail.com')
INSERT INTO customers VALUES('C0008','Bashana','Wickramasinghe','95325456V','0784568974','Main road','Millawana','Matale','bashWick@gmail.com')
INSERT INTO customers VALUES('C0009','Krishna','Himantha','95456123V','0715907095','Temple road','Rattota','Matale','khimantha@gmail.com')
INSERT INTO customers VALUES('C0010','Mahesh','Fernando','952364892V','0777895621','4th lane','Alwala','Matale','maheshF@gmail.com')



INSERT INTO appointment VALUES('A0001','C0001','Repair','2017-08-27','11:00','E0001')
INSERT INTO appointment VALUES('A0002','C0002','Repair','2017-09-21','01:00','E0002')
INSERT INTO appointment VALUES('A0003','C0003','Service','2017-09-24','04:00','E0004')
INSERT INTO appointment VALUES('A0004','C0004','Repair','2017-09-24','11:00','E0007')
INSERT INTO appointment VALUES('A0005','C0005','Service','2017-09-27','09:00','E0004')
INSERT INTO appointment VALUES('A0006','C0006','Repair','2017-09-27','01:00','E0007')
INSERT INTO appointment VALUES('A0007','C0007','Service','2017-09-28','02:00','E0008')
INSERT INTO appointment VALUES('A0008','C0008','Repair','2017-09-29','10:00','E0009')
INSERT INTO appointment VALUES('A0009','C0009','Repair','2017-08-30','08:00','E0010')
INSERT INTO appointment VALUES('A0010','C0010','Repair','2017-10-01','03:00','E0005')

INSERT INTO slots VALUES('SL0001','service','available','2017-10-01','14:00')
INSERT INTO slots VALUES('SL002','repair','available','2017-10-02','13:00')
INSERT INTO slots VALUES('SL003','service','unavailable','2017-10-01','11:00')
INSERT INTO slots VALUES('SL004','repair','available','2017-10-02','11:00')
INSERT INTO slots VALUES('SL005','service','unavailable','2017-10-03','11:00')
INSERT INTO slots VALUES('SL006','repair','available','2017-10-04','11:00')
INSERT INTO slots VALUES('SL007','service','unavailable','2017-10-04','11:00')
INSERT INTO slots VALUES('SL008','repair','available','2017-10-04','11:00')
INSERT INTO slots VALUES('SL009','service','available','2017-10-05','11:00')
INSERT INTO slots VALUES('SL010','repair','available','2017-10-05','11:00')
INSERT INTO slots VALUES('SL011','repair','available','2017-08-05','11:00')

---------------------------------------ishara DATA -2

INSERT INTO suppliers VALUES('SP0001','Hanks Garage','Katuwawala','Maharagama','0713789369','rathna@gmail.com','2017-01-02 08:00:00');
INSERT INTO suppliers VALUES('SP0002','Ignition Auto Inc.','Pittugala','Malabe','0776541239','madhu@gmail.com','2017-02-04 05:00:00');
INSERT INTO suppliers VALUES('SP0003','The Manic Machanic','Dikwalla','Matara','0759111222','nayani@gmail.com','2017-02-12 13:00:00');
INSERT INTO suppliers VALUES('SP0004','Vroom Auto Repair','Horana','Colombo','0716555333','dushan@ymail.com','2017-04-01 10:00:00');
INSERT INTO suppliers VALUES('SP0005','Classic Motor Repair','Kottawa','Pitipana','0786555879','amara@yahoo.com','2017-04-12 17:00:00');
INSERT INTO suppliers VALUES('SP0006','Woods Machanic','Kandy','Colombo','0728654123','perera@gmail.com','2017-04-25 15:00:00');
INSERT INTO suppliers VALUES('SP0007','Ottos Auto Diagnostics','Galle','Seeduwa','0776951123','waruna@ymail.com','2017-05-27 14:50:00');
INSERT INTO suppliers VALUES('SP0008','Hood Auto Specialists','Homagama','Waththala','0762451236','lasantha@yahoo.com','2017-06-11 09:32:00');
INSERT INTO suppliers VALUES('SP0009','Quick Start Machanix ','Hokandara','Kudamaduwa','0756884335','sulekani@gmail.com','2017-07-08 11:45:00');
INSERT INTO suppliers VALUES('SP0010','Mufflers Auto Service','Moratuwa','Kothalawala','0727656323','siriwasa@ymail.com','2017-08-25 20:00:00');
INSERT INTO suppliers VALUES('SP0011','Manual Motor Repair','Magama','Mulleriyawa','0782369258','mana@gmail.com','2017-08-26 09:00:00');
INSERT INTO suppliers VALUES('SP0012','Avira Auto Care','Dikwalla','Matara','0759846135','auto@gmail.com','2017-08-28 05:00:00');
INSERT INTO suppliers VALUES('SP0013','Car Surgeons','Galle','Jaffna','0781451152','surgeon@gmail.com','2017-08-30 13:00:00');
INSERT INTO suppliers VALUES('SP0014','Suburban Autobody','Kurunegala','Colombo','0716555333','suburban@ymail.com','2017-09-01 10:00:00');
INSERT INTO suppliers VALUES('SP0015','Car Doctor','Pitipana','Horana','0710658952','doctor@yahoo.com','2017-09-12 17:30:00');

INSERT INTO stocks VALUES('I0001','SP0011','Batteries','Lithium-Ion Batteries','Rayovac','Li-ion batteries are able to store significantly more energy',10,'8400.00','2017-07-08 11:45:00');
INSERT INTO stocks VALUES('I0002','SP0014','Lamps','D1S','Crystorama','Integral ignitor for projector systems',65,'35.00','2017-08-25 20:00:00');
INSERT INTO stocks VALUES('I0003','SP0001','Lamps','D5W','Bosch','reflector and lightning systems',4,'55.00','2017-09-25 15:00:00');
INSERT INTO stocks VALUES('I0004','SP0005','Tiers','Mud Tiers','Duracell','Best in wet,uneven,rocky terrain',2,'3500.00','2017-08-28 22:00:00');
INSERT INTO stocks VALUES('I0005','SP0008','Oils','Viscocity Engine Oil','Castrol','Thickness less in the cold than a 10w-30',0,'1500.00','2017-09-01 08:00:00');
INSERT INTO stocks VALUES('I0006','SP0010','Wiper Blades','Hybrid Wiper Blades','Rayovac','Hybrid window visibility is key to safe motoring',1,'2000.00','2017-09-04 17:30:00');
INSERT INTO stocks VALUES('I0007','SP0011','Lamps','D9S','Crystorama','Ignitor for projector systems',35,'32.00','2017-09-05 07:00:00');
INSERT INTO stocks VALUES('I0008','SP0004','Betteries','Western Cell Batteries','Cooper','Rechargeble batteries and NiMH',1,'6000.00','2017-09-06 05:00:00');
INSERT INTO stocks VALUES('I0009','SP0003','Engines','Combustion Engine','SAS Motors','Spark ignition and compression ignition',0,'9000.00','2017-09-08 17:00:00');
INSERT INTO stocks VALUES('I0010','SP0007','Lamps','D6R','Bosch','Integral ignitor for reflector and lightning systems',3,'55.00','2017-09-10 15:00:00');
INSERT INTO stocks VALUES('I0011','SP0009','Cables','Seat Cable','SASMotors','Cable for belts in seats',25,'1500.00','2017-09-21 18:00:00');
INSERT INTO stocks VALUES('I0012','SP0005','Filters','Air Filter','Duracell','Filter for pre air coolers',4,'5500.00','2017-09-10 15:30:00');
INSERT INTO stocks VALUES('I0013','SP0006','Hydraulics','Auto Hydrolic','Pennzoil','Hydrolics made for transmission engines',7,'3550.00','2017-09-15 10:32:00');
INSERT INTO stocks VALUES('I0014','SP0002','Fluids','General Fluid','Bosch','Fluids for normal engines',0,'100.00','2017-09-17 15:00:00');
INSERT INTO stocks VALUES('I0015','SP0009','Brake Friction','Down Brakes','Crystorama','Brakes made for 4 cylinder engines',45,'1580.00','2017-09-20 10:32:00');

INSERT INTO orders VALUES('OD0001','SP0001','2016-12-21','Received','2016-12-21 06:00:00');
INSERT INTO orders VALUES('OD0002','SP0003','2017-02-01','Received','2017-02-01 16:00:00');
INSERT INTO orders VALUES('OD0003','SP0005','2017-03-15','Not Received','2017-03-15 11:00:00');
INSERT INTO orders VALUES('OD0004','SP0008','2017-04-07','Received','2017-04-07 21:30:00');
INSERT INTO orders VALUES('OD0005','SP0004','2017-07-29','Not Received','2017-07-29 07:00:00');
INSERT INTO orders VALUES('OD0006','SP0011','2017-08-11','Received','2017-08-11 09:00:00');
INSERT INTO orders VALUES('OD0007','SP0015','2017-08-25','Received','2017-08-25 07:30:00');
INSERT INTO orders VALUES('OD0008','SP0012','2017-08-28','Not Received','2017-08-28 09:36:00');
INSERT INTO orders VALUES('OD0009','SP0006','2017-09-01','Received','2017-09-01 12:00:00');
INSERT INTO orders VALUES('OD0010','SP0008','2017-09-02','Received','2017-09-02 11:30:00');
INSERT INTO orders VALUES('OD0011','SP0009','2017-09-05','Received','2017-09-05 09:00:00');
INSERT INTO orders VALUES('OD0012','SP0010','2017-09-08','Not Received','2017-09-08 07:30:00');
INSERT INTO orders VALUES('OD0013','SP0003','2017-09-11','Received','2017-09-11 09:36:00');
INSERT INTO orders VALUES('OD0014','SP0007','2017-09-15','Not Received','2017-09-15 12:00:00');
INSERT INTO orders VALUES('OD0015','SP0004','2017-09-20','Not Received','2017-09-20 11:30:00');

INSERT INTO ordered_items VALUES('OD0001','I0002',25,'15000.00','375000.00');
INSERT INTO ordered_items VALUES('OD0003','I0008',15,'6500.00','97500.00');
INSERT INTO ordered_items VALUES('OD0015','I0009',4,'4200.00','16800.00');
INSERT INTO ordered_items VALUES('OD0014','I0006',10,'6250.00','62500.00');
INSERT INTO ordered_items VALUES('OD0010','I0015',50,'51000.00','255000.00');
INSERT INTO ordered_items VALUES('OD0009','I0013',18,'21000.00','378000.00');
INSERT INTO ordered_items VALUES('OD0002','I0006',20,'10050.00','201000.00');
INSERT INTO ordered_items VALUES('OD0004','I0007',7,'7500.00','52500.00');
INSERT INTO ordered_items VALUES('OD0007','I0004',22,'18000.00','396000.00');
INSERT INTO ordered_items VALUES('OD0005','I0003',26,'18250.00','474500.00');
INSERT INTO ordered_items VALUES('OD0012','I0011',24,'12250.00','294000.00');
INSERT INTO ordered_items VALUES('OD0010','I0010',20,'10050.00','201000.00');
INSERT INTO ordered_items VALUES('OD0006','I0014',7,'7500.00','52500.00');
INSERT INTO ordered_items VALUES('OD0002','I0011',22,'18000.00','396000.00');
INSERT INTO ordered_items VALUES('OD0009','I0001',26,'18250.00','474500.00');
INSERT INTO ordered_items VALUES('OD0005','I0005',24,'12250.00','294000.00');


--------------------------------------------------------shaleendra DATA -3

INSERT salescustomer VALUES ( 'SC0001','Riley9', '2988 Beachwood Loop, MidAmerican Bldg, Frankfort, KY, 76803', ' 011-7355240')
INSERT salescustomer VALUES ( 'SC0002','Shyla348', '245 E Cedar Tree Drive, Keith Bldg, Baton Rouge, Louisiana, 79969', '077-8580929')
INSERT salescustomer VALUES ( 'SC0003','Tilton7', '47 Edgewood Street, Dover, DE, 88115', ' 077-5709064')
INSERT salescustomer VALUES ( 'SC0004','Ignacio5', '3490 Hidden Buttonwood Circle, Columbia, South Carolina, 31946', '011-0901906')
INSERT salescustomer VALUES ( 'SC0005','Ben33', '437 Rockwood Avenue, Suite 1685, Nashville, TN, 62739', '071-5930127')
INSERT salescustomer VALUES ( 'SC0006','Kinder9', '3395 West Town Highway, Annapolis, MD, 56961', ' 070-2007014')
INSERT salescustomer VALUES ( 'SC0007','Mauldin5', '136 New Rockwood Pkwy, Calyon Bldg, Boston, Massachusetts, 19894','011-2569786')
INSERT salescustomer VALUES ( 'SC0008','Gomez2', '417 Front St, Enquirer Bldg, Montpelier, VT, 33301', ' 037-6226563')
INSERT salescustomer VALUES ( 'SC0009','Sharon4', '266 East Rock Hill Cir, Kearns Bldg, Boise, ID, 72811', '078-326-7571')
INSERT salescustomer VALUES ( 'SC0010','Mackey4', '38 South Waterview Avenue, Des Moines, Iowa, 82817', '033-150-9518')

INSERT Sales VALUES ( 'SA0001','SC0001', 14883.00, '2017-09-21')
INSERT Sales VALUES ( 'SA0002','SC0002', 21471.00, '2017-09-07')
INSERT Sales VALUES ( 'SA0003','SC0003', 7991.00, '2017-09-19')
INSERT Sales VALUES ( 'SA0004','SC0004', 41212.00, '2017-08-12')
INSERT Sales VALUES ( 'SA0005','SC0005', 39302.00, '2017-09-08')
INSERT Sales VALUES ( 'SA0006','SC0006', 26472.00, '2017-06-08')
INSERT Sales VALUES ( 'SA0007','SC0007', 46211.00, '2017-09-20')
INSERT Sales VALUES ( 'SA0008','SC0008', 21472.00, '2017-08-27')
INSERT Sales VALUES ( 'SA0009','SC0009', 41213.00, '2017-08-13')
INSERT Sales VALUES ( 'SA0010','SC0010', 26473.00, '2017-06-23')

INSERT sales_items VALUES ('SI0001','I0010','SA0001','Integral ignitor for reflector and lightning systems', 1, 0.00,  3500.00,5)
INSERT sales_items VALUES ('SI0002','I0004', 'SA0004','Best in wet,uneven,rocky terrain', 2, 500.00,  2500.00,3)
INSERT sales_items VALUES ('SI0003','I0009', 'SA0007', 'Spark ignition and compression ignition', 2, 10, 60.00,1)
INSERT sales_items VALUES ('SI0004','I0007', 'SA0005','Ignitor for projector systems', 3, 500.00,  4150.00,3)
INSERT sales_items VALUES ('SI0005','I0002','SA0003',' Thickness less in the cold than a 10w-30', 1, 0.00,  6000.00,3)
INSERT sales_items VALUES ('SI0006','I0001','SA0008', 'Hybrid window visibility is key to safe motoring', 6, 1000.00,  35000.00,1)
INSERT sales_items VALUES ('SI0007','I0005','SA0006','Thickness less in the cold than a 10w-30 ', 64.04, 2075,  32930,0)
INSERT sales_items VALUES ('SI0008','I0008','SA0003','Rechargeble batteries and NiMH', 1, 0,  32.00,1)
INSERT sales_items VALUES ('SI0009','I0006','SA0007','Li-ion batteries are able to store significantly more energy', 5, 900.00,  41100.00,1)
INSERT sales_items VALUES ('SI0010','I0004','SA0008','Thickness less in the cold than a 10w-30', 5, 500.00,  14500.00,0)

INSERT return_items VALUES ('RI0001', 'SA0003','I0008', 'not work properly', '2017-09-21', 5)
INSERT return_items VALUES ('RI0002','SA0007','I0009', 'broken', '2017-08-12', 2)
INSERT return_items VALUES ('RI0003','SA0008','I0001', 'not work properly', '2017-09-19',  1)
INSERT return_items VALUES ('RI0004','SA0003','I0002', 'some parts are broken', '2017-08-27', 4)
INSERT return_items VALUES ('RI0005','SA0004','I0004', 'broken', '2017-07-01', 3)
INSERT return_items VALUES ('RI0006','SA0008','I0004', 'some parts are not work properly', '2017-07-20',1)


-------------------------------------------------------------------------------tharidu DATA -5

INSERT INTO vehicles VALUES('V0001','C0001','CAA-45412','Car','Toyota','Prius','2017-01-02 08:00:00');
INSERT INTO vehicles VALUES('V0002','C0001','ACB-55123','Car','Suzuki','Wagon R','2017-02-04 05:00:00');
INSERT INTO vehicles VALUES('V0003','C0002','PD-2399','Car','Honda','Fit','2017-02-12 13:00:00');
INSERT INTO vehicles VALUES('V0004','C0003','CSA-76542','Car','Toyota','Vitz F','2017-04-01 10:00:00');
INSERT INTO vehicles VALUES('V0005','C0004','ABC-9988','Car','Toyota','Prius','2017-04-12 17:00:00');
INSERT INTO vehicles VALUES('V0006','C0005','CA-90854','Car','Porsche','Cayen','2017-04-25 15:00:00');
INSERT INTO vehicles VALUES('V0007','C0008','BNM-3350','Car','Honda','vezel','2017-05-27 14:50:00');
INSERT INTO vehicles VALUES('V0008','C0007','CBD-11450','Car','Toyota','Aqua','2017-06-11 09:32:00');
INSERT INTO vehicles VALUES('V0009','C0006','AGF-87456','Car','Suzuki','Alto','2017-07-08 11:45:00');
INSERT INTO vehicles VALUES('V0010','C0009','KJH-45520','Car','Nissan','Leaf','2017-08-25 20:00:00');

INSERT INTO services VALUES('S0001','V0002','2016-12-21 06:00:00',45000,'2017-01-02',0);
INSERT INTO services VALUES('S0002','V0001','2017-02-01 16:00:00',33100,'2017-02-05',0);
INSERT INTO services VALUES('S0003','V0002','2017-03-15 11:00:00',22000,'2017-03-22',0);
INSERT INTO services VALUES('S0004','V0006','2017-04-07 21:30:00',55410,'2017-04-17',0);
INSERT INTO services VALUES('S0005','V0004','2017-07-29 07:00:00',15870,'2017-08-02',0);
INSERT INTO services VALUES('S0006','V0003','2017-08-11 09:00:00',76850,'2017-08-20',0);
INSERT INTO services VALUES('S0007','V0005','2017-08-25 07:30:00',25600,'2017-08-30',0);
INSERT INTO services VALUES('S0008','V0010','2017-09-12 09:36:00',45620,'2017-09-21',0);
INSERT INTO services VALUES('S0009','V0007','2017-09-26 12:00:00',16890,'2017-10-01',0);
INSERT INTO services VALUES('S0010','V0008','2017-10-02 11:30:00',87596,'2017-10-05',0);

INSERT INTO service_types VALUES('Engine Oil Type/Test','Use the engine to measure oil quality','5200.00');
INSERT INTO service_types VALUES('Transmission Oil Type/Test','ATF qualification testing and oil analysis','7240.00');
INSERT INTO service_types VALUES('Brake Fluid Type/Test','Test if a Brake fluid is DOT 3 and 4 or DOT 5','3250.00');
INSERT INTO service_types VALUES('Repl.of Brake Fluid Type/Test','Remove contaminants from the car engine"s oil that can accumulate over time','2500.00');
INSERT INTO service_types VALUES('Inverter Coolant Test','Keep the engine temperature in check','4000.00');
INSERT INTO service_types VALUES('Radiator Coolant Test','Measure the concentration level and condition of anti-freeze','2500.00');
INSERT INTO service_types VALUES('Oil Filter','Remove contaminants from the car engine"s oil that can accumulate over time','2500.00');
INSERT INTO service_types VALUES('Air Filter','Condenser coil back flushed and tune up','4500.00');
INSERT INTO service_types VALUES('A/C Filter','Change the air condition filter','7600.00');
INSERT INTO service_types VALUES('Engine Tuneup','Remove loose debris and degrease','3000.00');
INSERT INTO service_types VALUES('Spark Plug Change','Clean all surface areas around it,apply anti-seize tho the threads and replace new spark plug','7500.00');
INSERT INTO service_types VALUES('HV Battery Service','Replaced the battery with remanufactured units','5000.00');
INSERT INTO service_types VALUES('HV Battery Cooling System Service','Add a pre filter to the back seat vent grille','8200.00');
INSERT INTO service_types VALUES('Brake Service','Locate the brake caliper to service brakes','6350.00');
INSERT INTO service_types VALUES('Rep.Brake Pad Front/Rear','Remove caliper,check the rotor,wheel bearings and replace Brake pads','5500.00');
INSERT INTO service_types VALUES('Engine Scanning','Read trouble codes and erase them','9000.00');
INSERT INTO service_types VALUES('HV Battery Usable Capacity','Apply charging current to an imbalanced battery','5890.00');

INSERT INTO provided_services VALUES('S0001',3,'5000.00','2017-01-02 11:00:00');
INSERT INTO provided_services VALUES('S0002',4,'3500.00','2017-03-21 05:00:00');
INSERT INTO provided_services VALUES('S0004',5,'9500.00','2017-04-15 19:00:00');
INSERT INTO provided_services VALUES('S0003',2,'4450.00','2017-05-02 08:00:00');
INSERT INTO provided_services VALUES('S0005',1,'5100.00','2017-05-22 14:00:00');
INSERT INTO provided_services VALUES('S0006',8,'6580.00','2017-06-05 12:20:00');
INSERT INTO provided_services VALUES('S0007',9,'7450.00','2017-06-29 17:15:00');
INSERT INTO provided_services VALUES('S0008',6,'6320.00','2017-07-12 07:00:00');
INSERT INTO provided_services VALUES('S0009',7,'2590.00','2017-08-08 18:30:00');
INSERT INTO provided_services VALUES('S0010',10,'5500.00','2017-09-06 09:40:00');

INSERT INTO repairs VALUES('R0001','E0001','V0003','2017-02-19',0);
INSERT INTO repairs VALUES('R0002','E0003','V0004','2017-02-28',0);
INSERT INTO repairs VALUES('R0003','E0002','V0004','2017-03-11',0);
INSERT INTO repairs VALUES('R0004','E0003','V0005','2017-04-27',0);
INSERT INTO repairs VALUES('R0005','E0006','V0010','2017-05-10',0);
INSERT INTO repairs VALUES('R0006','E0008','V0006','2017-05-24',0);
INSERT INTO repairs VALUES('R0007','E0009','V0002','2017-06-20',0);
INSERT INTO repairs VALUES('R0008','E0004','V0001','2017-07-01',0);
INSERT INTO repairs VALUES('R0009','E0010','V0007','2017-08-10',0);
INSERT INTO repairs VALUES('R0010','E0007','V0008','2017-09-29',0);

INSERT INTO repair_types VALUES('Remove Aftermarket Alarm','Tap into circuits and settle power','5400.00');
INSERT INTO repair_types VALUES('Replace Intake Manifold Gaskets','Repair leakage of air and the fuel between metal engine parts','8500.00');
INSERT INTO repair_types VALUES('Replace Ignition Coils','Replace and repair spark plugs','7100.00');
INSERT INTO repair_types VALUES('Loose Fuel Caps','Check the engine and add new fuel caps','2500.00');
INSERT INTO repair_types VALUES('Replace Oxygen Sensor','Place a special cover over the sensor','6550.00');
INSERT INTO repair_types VALUES('Replace Catalytic Converter','Repair fuel injector and spark plugs ','6800.00');
INSERT INTO repair_types VALUES('Replace Mass Air Flow Sensor','Peplace air filters','4550.00');
INSERT INTO repair_types VALUES('Remove Exhaust Gas Recirculation Valve','Clean the emissions system','3890.00');
INSERT INTO repair_types VALUES('Replace Engine Coolent Temperature Sensor','Analyze the carMD and replace','7450.00');
INSERT INTO repair_types VALUES('Pepair Greenish Fluid','Settle leaking radiator fluid ','4650.00');

INSERT INTO provided_repairs VALUES('R0001',3,'7500.00','2017-01-02 11:00:00');
INSERT INTO provided_repairs VALUES('R0002',4,'10000.00','2017-02-15 07:00:00');
INSERT INTO provided_repairs VALUES('R0003',1,'8500.00','2017-03-05 16:00:00');
INSERT INTO provided_repairs VALUES('R0004',5,'5000.00','2017-04-11 20:00:00');
INSERT INTO provided_repairs VALUES('R0005',1,'6800.00','2017-05-04 10:00:00');
INSERT INTO provided_repairs VALUES('R0006',2,'7460.00','2017-06-01 15:30:00');
INSERT INTO provided_repairs VALUES('R0007',6,'4210.00','2017-07-21 09:50:00');
INSERT INTO provided_repairs VALUES('R0008',8,'6380.00','2017-08-15 12:45:00');
INSERT INTO provided_repairs VALUES('R0009',10,'9200.00','2017-09-03 19:30:00');
INSERT INTO provided_repairs VALUES('R0010',9,'3990.00','2017-09-25 08:15:00');

INSERT INTO error_codes VALUES('P0401','Insufficient EGR flow','Pinging when the vehicle is at higher speeds','2017-03-15 07:00:00');
INSERT INTO error_codes VALUES('P2270','Oxygen sensor stuck','Fault in the air/fuel sensor circuit','2017-04-04 15:00:00');
INSERT INTO error_codes VALUES('P0729','Gear ratio problem','Transmission fluid is low','2017-04-25 09:00:00');
INSERT INTO error_codes VALUES('P0614','ECM/TCM incompatible','The replacement ECM/TCM pat is not configured to work with existing part','2017-06-30 16:25:00');
INSERT INTO error_codes VALUES('P0218','Transmission over temperature','Lines are restricted and the cooling fan is not operating','2017-07-24 10:00:00');
INSERT INTO error_codes VALUES('C0128','Low Brake Fluid Circuit Low','Open the cap to the Brake fluid reservoir','2017-07-30 11:45:00');
INSERT INTO error_codes VALUES('B2645','Ambient Light Sensor Circuit','Voltage is low in the ambient light sensor signal service','2017-08-12 22:00:00');
INSERT INTO error_codes VALUES('U0230','Lost Communucation With Rear Gate Module','Engine light on(warning light)','2017-08-30 08:35:00');
INSERT INTO error_codes VALUES('B1416','Coolant Circulation Pump','Check the fuse including volt dropping','2017-09-09 15:24:00');
INSERT INTO error_codes VALUES('C0245','Wheel Speed Sensor Frequency Error','Alter oil pressure fed into the lifter','2017-10-01 10:00:00');

INSERT INTO vehicle_errors VALUES('R0001',4,'Pending','2017-01-13 12:00:00');
INSERT INTO vehicle_errors VALUES('R0003',5,'Finished','2017-02-27 20:05:00');
INSERT INTO vehicle_errors VALUES('R0002',3,'Pending','2017-04-14 08:30:00');
INSERT INTO vehicle_errors VALUES('R0004',1,'Pending','2017-06-15 16:20:00');
INSERT INTO vehicle_errors VALUES('R0005',2,'Finished','2017-07-21 17:00:00');
INSERT INTO vehicle_errors VALUES('R0008',7,'Pending','2017-07-30 14:36:00');
INSERT INTO vehicle_errors VALUES('R0009',8,'Pending','2017-08-12 07:00:00');
INSERT INTO vehicle_errors VALUES('R0010',6,'Finished','2017-08-21 19:21:00');
INSERT INTO vehicle_errors VALUES('R0006',9,'Pending','2017-09-03 22:15:00');
INSERT INTO vehicle_errors VALUES('R0007',10,'Finished','2017-09-23 11:53:00');


---------------------------------------------------------------------------sajith DATA  -6

INSERT INTO administrator  VALUES  ('AD001','admin','admin')
INSERT INTO administrator  VALUES  ('AD002','1','1')
INSERT INTO administrator  VALUES  ('AD003','2','2')

INSERT INTO rental_vehicle VALUES  ('RV0001','Suzuki', 'Alto-Premium', 2015, 'Diesel' , 12500 , 'Available' ,80, 4250, 'ABC-1200', 42.50, 'Car',15000)
INSERT INTO rental_vehicle VALUES  ('RV0002','Toyota', 'Yaris', 2014, 'Petrol' , 15440, 'Not-Available' , 80, 5250.00, 'KB-3250', 52.50, 'Car',27500.00)
INSERT INTO rental_vehicle VALUES  ('RV0003','Toyota', 'Axio-Hybrid', 2016, 'Petrol' , 12500, 'Available' , 80, 6950.00, 'CAB-1252', 69.50, 'Car',28000.00)
INSERT INTO rental_vehicle VALUES  ('RV0004','Toyota', 'Allion 260', 2015, 'Petrol' , 8150, 'Not-Available' , 80, 7950.00, 'CAB-3025', 79.50, 'Car',29000.00)
INSERT INTO rental_vehicle VALUES  ('RV0005','BMW', '320-White', 2015, 'Petrol' , 12000, 'Available' , 80, 18500.00, 'ABC-3232', 185.00, 'Car',40000.00)
INSERT INTO rental_vehicle VALUES  ('RV0006','Bajaj', 'CT-100', 2012, 'Petrol' , 55400, 'Available' , 100, 3500.00, 'AB-5245', 35.00, 'Bike',7500.00)
INSERT INTO rental_vehicle VALUES  ('RV0007','Kawasaki', 'L100', 2012, 'Petrol' , 28500, 'Not-Available' , 100, 4500.00, 'CD-5645', 45.00, 'Bike',8500.00)
INSERT INTO rental_vehicle VALUES  ('RV0008','Toyota ', 'Hiace-184', 2010, 'Diesel' , 15440, 'Not-Available' , 100, 8950.00, 'D5-678', 89.00, 'Van',25000.00)
INSERT INTO rental_vehicle VALUES  ('RV0009','Mitsubishi', 'I-300', 2012, 'Diesel' , 19500, 'Available' , 100, 9500.00, 'FG-6978', 95.00, 'Van',30000.00)
INSERT INTO rental_vehicle VALUES  ('RV0010','Mazda', '6', 2014, 'Petrol' , 4500, 'Available' , 80, 15000, 'ABC-2222', 150.00, 'Car',35000.00 )

INSERT INTO rental_details  VALUES  ('RD0001','C0001','RV0001','2015-12-13', '2015-12-13', 5000, 22500, 3500,'yes','no')
INSERT INTO rental_details  VALUES  ('RD0002','C0002','RV0002','2015-11-13', '2015-11-15', 2000, 32500, 4500,'no','no')
INSERT INTO rental_details  VALUES  ('RD0003','C0003','RV0003','2015-08-01', '2015-08-03', 6000, 23500, 10000,'yes','yes')
INSERT INTO rental_details  VALUES  ('RD0004','C0004','RV0004','2016-02-03', '2016-02-05', 8000, 15500, 12000,'yes','no')
INSERT INTO rental_details  VALUES  ('RD0005','C0005','RV0005','2016-08-23', '2016-08-25', 5000, 22320, 4500,'yes','yes')
INSERT INTO rental_details  VALUES  ('RD0006','C0006','RV0006','2017-06-12', '2017-06-15', 3000, 12780, 3500,'no','no')
INSERT INTO rental_details  VALUES  ('RD0007','C0007','RV0007','2017-04-25', '2017-04-25', 2000, 20136, 2500,'yes','no')
INSERT INTO rental_details  VALUES  ('RD0008','C0008','RV0008','2017-03-20', '2017-03-22', 8000, 45810, 4000,'yes','yes')
INSERT INTO rental_details  VALUES  ('RD0009','C0009','RV0009','2017-07-22', '2017-07-24', 10000, 21580, 9000,'no','no')
INSERT INTO rental_details  VALUES  ('RD0010','C0010','RV0010','2017-05-15', '2017-05-16', 12000, 12369, 8000,'yes','no')

INSERT INTO rental_bill_details  VALUES  ('RB0001','RD0001','2015-12-13',3600.00,22800,1000)
INSERT INTO rental_bill_details  VALUES  ('RB0002','RD0002','2015-11-15',4000.00,32950,250)
INSERT INTO rental_bill_details  VALUES  ('RB0003','RD0003','2015-12-13',8000.00,24000,3500)
INSERT INTO rental_bill_details  VALUES  ('RB0004','RD0004','2016-02-05',9500.00,15800,200)
INSERT INTO rental_bill_details  VALUES  ('RB0005','RD0005','2015-12-13',12000.00,22450,4500)
INSERT INTO rental_bill_details  VALUES  ('RB0006','RD0006','2017-06-15',5600.00,13000,1100)
INSERT INTO rental_bill_details  VALUES  ('RB0007','RD0007','2017-04-25',7500.00,21000,500)
INSERT INTO rental_bill_details  VALUES  ('RB0008','RD0008','2017-03-22',8200.00,45900,0)
INSERT INTO rental_bill_details  VALUES  ('RB0009','RD0009','2017-07-24',7500.00,21670,600)
INSERT INTO rental_bill_details  VALUES  ('RB0010','RD0010','2017-05-16',4800.00,12490,500)

INSERT INTO rental_invoice  VALUES  ('IN0001','RD0001','2015-12-13',3600.00)
INSERT INTO rental_invoice  VALUES  ('IN0002','RD0002','2015-11-15',12000.00)
INSERT INTO rental_invoice  VALUES  ('IN0003','RD0003','2015-12-13',5600.00)
INSERT INTO rental_invoice  VALUES  ('IN0004','RD0004','2016-02-05',4800.00)
INSERT INTO rental_invoice  VALUES  ('IN0005','RD0005','2015-12-13',5500.00)
INSERT INTO rental_invoice  VALUES  ('IN0006','RD0006','2017-06-15',4500.00)
INSERT INTO rental_invoice  VALUES  ('IN0007','RD0007','2015-12-13',4000.00)
INSERT INTO rental_invoice  VALUES  ('IN0008','RD0008','2017-07-24',2800.00)
INSERT INTO rental_invoice  VALUES  ('IN0009','RD0009','2017-04-25',9500.00)
INSERT INTO rental_invoice  VALUES  ('IN0010','RD0010','2017-05-16',8700.00)

--------------------------------------------------------------------------------------------------------lahiru DATA -7

INSERT INTO equipments VALUES('EQ0001','Auto Diagnostic Scanner F3-W','OEM Level coverage for USA,Asian,Europian vehicles',1579547,'65000.00','Brand New','SP0002','2018-04-04',1);
INSERT INTO equipments VALUES('EQ0002','Four Post Wheel Alignment Lift','Turntable and slip plate for wheel alignment',1687226,'120000.00','Used','SP0001','2018-06-08',1);
INSERT INTO equipments VALUES('EQ0003','Hydraulic Washing Lift','Plunger power pack FRP coated, IOR receiver powder coated',1287654,'560000.00','Used','SP0004','2019-06-08',1);
INSERT INTO equipments VALUES('EQ0004','Car Washer','High-pressure cleaning',1479531,'180000.00','Brand New','SP0001','2018-12-17',1);
INSERT INTO equipments VALUES('EQ0005','Spark Plug Cleaner and Tester','Cleaning and testing of sparkplug, Testing carried out under simulated conditions prevailing in IC engine',6547821,'380000.00','Brand New','SP0008','2020-12-25',1);
INSERT INTO equipments VALUES('EQ0006','Technical Work Table','This is known for providing motionless work surface for easy and hassle free operations',1475231,'100000.00','Brand New','SP0007','2022-02-17',1);
INSERT INTO equipments VALUES('EQ0007','Automatic Tyre Changer','This is equipped with modern features, four jaws, a bead breakers and safety precautions',7569531,'180000.00','Brand New','SP0010','2020-04-17',1);
INSERT INTO equipments VALUES('EQ0008','Pneumatic Wrenches','this is used in power plants, mining & cement industries, railways industries, fertilizers/chemicals',7499531,'150000.00','Brand New','SP0012','2018-11-05',1);
INSERT INTO equipments VALUES('EQ0009','Grease Pumps(50 kg)','Pressure withstanding capacities',1475861,'280000.00','Brand New','SP0013','2018-02-27',1);
INSERT INTO equipments VALUES('EQ0010','Trolley Tool','store small equipments, easy movement from one place to another',914531,'230000.00','Brand New','SP0014','2020-03-30',1);

INSERT INTO equipment_repair VALUES('EQR0001','EQ0001','Clean',1974,'2500.00','2017-02-17');
INSERT INTO equipment_repair VALUES('EQR0002','EQ0003','Changr oil',2077,'4500.00','2017-04-27');
INSERT INTO equipment_repair VALUES('EQR0003','EQ0004','Clean',2378,'1500.00','2017-04-29');
INSERT INTO equipment_repair VALUES('EQR0004','EQ0002','Clean',2971,'5500.00','2017-05-07');
INSERT INTO equipment_repair VALUES('EQR0005','EQ0007','Change nuts',4877,'5000.00','2017-05-17');
INSERT INTO equipment_repair VALUES('EQR0006','EQ0008','Change oil',1566,'2500.00','2017-05-22');
INSERT INTO equipment_repair VALUES('EQR0007','EQ0006','Clean',7889,'800.00','2017-05-27');
INSERT INTO equipment_repair VALUES('EQR0008','EQ0003','Change spins',7874,'8500.00','2017-06-17');
INSERT INTO equipment_repair VALUES('EQR0009','EQ0002','Change oil',9972,'700.00','2017-07-17');
INSERT INTO equipment_repair VALUES('EQR0010','EQ0001','Clean',1193,'500.00','2017-08-17');

INSERT INTO rental_vehicle_renew VALUES('RVR0001','RV0007','License',1474,'1500.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0002','RV0007','Insurance',1872,'2500.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0003','RV0007','Smoke Test',1418,'1000.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0004','RV0005','Insurance',1787,'2500.00','2017-03-27');
INSERT INTO rental_vehicle_renew VALUES('RVR0005','RV0005','Smoke Test',1656,'1000.00','2017-03-27');
INSERT INTO rental_vehicle_renew VALUES('RVR0006','RV0004','License',1725,'1500.00','2017-03-27');
INSERT INTO rental_vehicle_renew VALUES('RVR0007','RV0004','Smoke Test',2763,'1500.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0008','RV0004','Insurance',8866,'1500.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0009','RV0001','License',7824,'1500.00','2017-02-17');
INSERT INTO rental_vehicle_renew VALUES('RVR0010','RV0001','Smoke Test',7956,'1500.00','2017-04-17');

INSERT INTO rental_vehicle_repair_service VALUES('RVRS0001','RV0007','Repair','Engine tune-up',875146,'500.00',10175,'2017-01-11');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0002','RV0008','Repair','Change Air filter',172546,'2000.00',25175,'2017-02-10');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0003','RV0001','Service','After 100000km',878546,'6500.00',100050,'2017-02-02');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0004','RV0001','Repair','Engine tune-up',985462,'600.00',10005,'2017-02-21');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0005','RV0002','Repair','Change Battery',125476,'7000.00',100175,'2017-03-01');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0006','RV0005','Repair','Cleaning Head Lights',124556,'2500.00',125575,'2017-03-11');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0007','RV0007','Service','After 50000km',802146,'8500.00',50175,'2017-03-21');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0008','RV0008','Service','After 50000km',985646,'8500.00',50475,'2017-04-11');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0009','RV0002','Repair','Engine tune-up',987346,'500.00',50975,'2017-04-29');
INSERT INTO rental_vehicle_repair_service VALUES('RVRS0010','RV0003','Service','After 150000km',578646,'10500.00',150105,'2017-05-11');


-------------------------------------------------------------------------------- Sameer DATA -8


INSERT INTO bills (b_id, b_type, b_monthly_amount, b_issue_date) VALUES
('BL0001', 'Electricity', 14957.79, '01-31-2017'),
('BL0002', 'Electricity', 10795.26, '02-28-2017'),
('BL0003', 'Electricity', 18350.85, '03-31-2017'),
('BL0004', 'Electricity', 16279.79, '04-30-2017'),
('BL0005', 'Electricity', 15142.39, '05-31-2017'),
('BL0006', 'Electricity', 17482.54, '06-30-2017'),
('BL0007', 'Electricity', 14368.83, '07-31-2017'),
('BL0008', 'Electricity', 13648.49, '08-31-2017'),
('BL0009', 'Electricity', 18257.72, '09-30-2017'),
('BL0010', 'Internet', 14157.79, '01-31-2017'),
('BL0011', 'Internet', 10395.26, '02-28-2017'),
('BL0012', 'Internet', 18350.85, '03-31-2017'),
('BL0013', 'Internet', 14957.79, '04-30-2017'),
('BL0014', 'Internet', 14142.39, '05-31-2017'),
('BL0015', 'Internet', 17482.54, '06-30-2017'),
('BL0016', 'Internet', 16368.83, '07-31-2017'),
('BL0017', 'Internet', 17648.49, '08-31-2017'),
('BL0018', 'Internet', 12257.72, '09-30-2017'),
('BL0019', 'Water', 14587.79, '01-31-2017'),
('BL0020', 'Water', 25486.26, '02-28-2017'),
('BL0021', 'Water', 15378.85, '03-31-2017'),
('BL0022', 'Water', 14957.79, '04-30-2017'),
('BL0023', 'Water', 15782.39, '05-31-2017'),
('BL0024', 'Water', 17482.54, '06-30-2017'),
('BL0025', 'Water', 16785.83, '07-31-2017'),
('BL0026', 'Water', 12784.49, '08-31-2017'),
('BL0027', 'Water', 18763.72, '09-30-2017');

INSERT INTO bill_payments (bp_b_id, bp_paid_amount, bp_paid_date) VALUES
('BL0001', 14957.79, '01-31-2017'),
('BL0002', 10795.26, '02-28-2017'),
('BL0003', 18350.85, '03-31-2017'),
('BL0004', 16279.79, '04-30-2017'),
('BL0005', 15142.39, '05-31-2017'),
('BL0006', 17482.54, '06-30-2017'),
('BL0007', 14368.83, '07-31-2017'),
('BL0008', 13648.49, '08-31-2017'),
('BL0009', 18257.72, '09-30-2017'),
('BL0010', 14157.79, '01-31-2017'),
('BL0011', 10395.26, '02-28-2017'),
('BL0012', 18350.85, '03-31-2017'),
('BL0013', 14957.79, '04-30-2017'),
('BL0014', 14142.39, '05-31-2017'),
('BL0015', 17482.54, '06-30-2017'),
('BL0016', 16368.83, '07-31-2017'),
('BL0017', 17648.49, '08-31-2017'),
('BL0018', 12257.72, '09-30-2017'),
('BL0019', 14587.79, '01-31-2017'),
('BL0020', 25486.26, '02-28-2017'),
('BL0021', 15378.85, '03-31-2017'),
('BL0022', 14957.79, '04-30-2017'),
('BL0023', 15782.39, '05-31-2017'),
('BL0024', 17482.54, '06-30-2017'),
('BL0025', 16785.83, '07-31-2017'),
('BL0026', 12784.49, '08-31-2017'),
('BL0027', 18763.72, '09-30-2017');


INSERT INTO loans (l_id, l_lender_name, l_start_date, l_period, l_amount, l_rate) VALUES
('LN0001', 'Bank Of Ceylon', '01-15-2017', 12, 200000.00, 4.67),
('LN0002', 'Bank Of Ceylon', '01-15-2017', 12, 250000.00, 7.78),
('LN0003', 'Bank Of Ceylon', '01-15-2017', 36, 300000.00, 10.12),
('LN0004', 'Bank Of Ceylon', '01-15-2017', 48, 450000.00, 8.99),
('LN0005', 'Bank Of Ceylon', '01-15-2017', 12, 500000.00, 11.00),
('LN0006', 'Hatton National Bank', '01-15-2017', 12, 325000.00, 14.05),
('LN0007', 'Hatton National Bank', '01-15-2017', 48, 150000.00, 12.11),
('LN0008', 'Hatton National Bank', '01-15-2017', 12, 175000.00, 12.89),
('LN0009', 'Hatton National Bank', '01-15-2017', 48, 285000.00, 6.98),
('LN0010', 'Commercial Bank', '01-15-2017', 36, 180000.00, 6.80);

INSERT INTO installments (ins_id, ins_l_id, ins_amount, ins_year, ins_month) VALUES
('IN0001', 'LN0001', 17445.00, 2017, 2),
('IN0002', 'LN0001', 17445.00, 2017, 3),
('IN0003', 'LN0001', 17445.00, 2017, 4),
('IN0004', 'LN0001', 17445.00, 2017, 5),
('IN0005', 'LN0001', 17445.00, 2017, 6),
('IN0006', 'LN0001', 17445.00, 2017, 7),
('IN0007', 'LN0001', 17445.00, 2017, 8),
('IN0008', 'LN0001', 17445.00, 2017, 9),
('IN0009', 'LN0001', 17445.00, 2017, 10),
('IN0010', 'LN0001', 17445.00, 2017, 11),
('IN0011', 'LN0001', 17445.00, 2017, 12),
('IN0012', 'LN0001', 17445.00, 2018, 1);

INSERT INTO loan_payments (lp_ins_id, lp_l_id, lp_payment_date, lp_payment_amount) VALUES
('IN0001', 'LN0001', '01-15-2017', 17445.00),
('IN0002', 'LN0001', '02-15-2017', 17445.00),
('IN0003', 'LN0001', '03-15-2017', 17445.00),
('IN0004', 'LN0001', '04-15-2017', 17445.00),
('IN0005', 'LN0001', '05-15-2017', 17445.00),
('IN0006', 'LN0001', '06-15-2017', 17445.00),
('IN0007', 'LN0001', '07-15-2017', 17445.00),
('IN0008', 'LN0001', '08-15-2017', 17445.00),
('IN0009', 'LN0001', '09-15-2017', 17445.00),
('IN0010', 'LN0001', '10-15-2017', 17445.00),
('IN0011', 'LN0001', '11-15-2017', 17445.00);
