#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 0b4fe9bb-8aa1-41ae-a993-00ca87ac925c -t
    fi
    cd ../
fi

docker-compose up -d
