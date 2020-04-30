USE Airport

SELECT p.[Name],
	p.Seats AS [Seats],
	COUNT(t.Id) AS [Passengers Count]
FROM Planes AS p
LEFT OUTER JOIN Flights AS f
ON f.PlaneId = p.Id
LEFT OUTER JOIN Tickets AS t
ON t.FlightId = f.Id
GROUP BY p.[Name], p.Seats
ORDER BY [Passengers Count] DESC, p.[Name], p.Seats;