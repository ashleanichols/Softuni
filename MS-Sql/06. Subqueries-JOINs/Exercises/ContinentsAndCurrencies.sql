USE Geography

SELECT k.ContinentCode, k.CurrencyCode, k.CountOfCurrency
FROM(
	SELECT
		c.ContinentCode,
		c.CurrencyCode,
		COUNT(c.CurrencyCode) AS CountOfCurrency,
		DENSE_RANK() OVER (PARTITION BY c.ContinentCode 
		ORDER BY COUNT(c.CurrencyCode) DESC) AS [CurrencyRank]
	FROM Countries AS c
	GROUP BY c.ContinentCode, c.CurrencyCode
	HAVING COUNT(c.CurrencyCode) > 1) AS k
WHERE k.CurrencyRank = 1
ORDER BY k.ContinentCode;