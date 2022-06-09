#!/bin/bash

if $1 $2; then
    echo "FALSE POSITIVE! Expected failure but succeeded"
else
    echo "Failed as expected"
fi
