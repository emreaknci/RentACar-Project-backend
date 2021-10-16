select r.Id RentId, u.FirstName,u.LastName,b.Name Marka,c.Description Açıklama 
from Rentals r 
inner join  Cars c on r.CarId=c.Id 
inner join Customers cu on r.CustomerId=cu.UserId
inner join Users u on u.Id=cu.UserId
inner join Brands b on b.Id=c.BrandId