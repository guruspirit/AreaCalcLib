SELECT 
	tmp.GoodName, 
    cat.CategoryName
FROM (SELECT
		  GoodName, 
          CategoryId 
      FROM goods AS g
      LEFT JOIN goods_categories AS gc 
	  ON g.GoodId = gc.GoodId)  AS tmp 
LEFT JOIN categories AS cat 
ON tmp.CategoryId = cat.CategoryId;
