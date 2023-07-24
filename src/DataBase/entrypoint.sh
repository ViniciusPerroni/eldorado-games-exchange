#!/bin/bash
set -e
echo "Running SQL script..."
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "#C4r4MuRu" -d master -i /docker-entrypoint-initdb.d/CREATE_DATA_BASE.sql
echo "Starting SQL Server..."
/opt/mssql/bin/sqlservr