SELECT
    p.ProductName,
    c.CategoryName
FROM
    Products p
        LEFT JOIN
    ProductCategoryMap pcm ON p.ProductID = pcm.ProductID 
        LEFT JOIN
    ProductCategories c ON pcm.CategoryID = c.CategoryID
ORDER BY
    p.ProductName, c.CategoryName;
