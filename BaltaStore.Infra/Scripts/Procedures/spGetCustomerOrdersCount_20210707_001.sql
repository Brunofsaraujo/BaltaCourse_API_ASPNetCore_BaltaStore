CREATE PROCEDURE spGetCustomerOrdersCount @Document CHAR(11) AS
SELECT
    c."Id",
    CONCAT(c."FirstName", '', c."LastName") AS "Name",
    c."Document",
    COUNT(o."Id") AS "Orders"
FROM
    "Customer" c
    JOIN "Order" o ON o."CustomerId" = c."Id"
WHERE
    c."Document" = @Document
GROUP BY
    c."Id",
    c."Document",
    c."FirstName",
    c."LastName"