docker ps -a

docker exec -i postgres psql -U program flights < test/flights.dump