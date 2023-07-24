FROM mcr.microsoft.com/mssql/server:2022-latest

ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=#C4r4MuRu
ENV MSSQL_DB_NAME=DEV_GAMES_EXCHANGE

COPY CREATE_DATA_BASE.sql /usr/src/

RUN /opt/mssql/bin/sqlservr --accept-eula & sleep 90 \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P '#C4r4MuRu' -d master -i /usr/src/CREATE_DATA_BASE.sql \
    && pkill sqlservr