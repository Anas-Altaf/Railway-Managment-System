CREATE TABLE Passenger (
  p_email_id VARCHAR(255) PRIMARY KEY,
  p_name VARCHAR(255) NOT NULL, 
  p_phone_number VARCHAR(20) NOT NULL, 
  p_password VARCHAR(255) NOT NULL, 
  p_cnic CHAR(13) UNIQUE NOT NULL, 
  p_picture BLOB 
);


INSERT INTO PASSENGER
Values ('umair2', 'umairpass');

INSERT INTO PASSENGER
Values ('anas2', 'anaspass');