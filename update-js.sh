#!/bin/bash

filename=$(wget --no-check-certificate -qO- https://www.sanita.puglia.it/prenotazione-vaccino-covid19/ | sed -En 's|^.*<script src="\.\/(main-es2015.+?)" type="module">.*$|\1|p');

if [ -z "$filename" ]
then
	exit 1;
fi

wget --no-check-certificate -q -O main.js https://www.sanita.puglia.it/prenotazione-vaccino-covid19/$filename;
