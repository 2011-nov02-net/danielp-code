# a dockerfile is a list of instructions for how to build  anew image from a baseline
# of some already existing image

# 1. choose a base image witht he dependencies for the program we're going to copy in
FROM mcr.microsoft.com/dotnet/runtime:5.0

# 2. copy our program into the image
#from outside our image to inside 
#copy source destination
COPY publish/ /app
#can be put anywhere, but becuase where the only one here, we'll just choose a short path

# 3. configure it with the command to use to start containers
CMD dotnet /app/DockerConsoleApp.dll



#how to use 
# 1. dotnet publish -o publish
# 2. docker build -t docker-consoleapp .
# 3. docker run docker-consoleapp
