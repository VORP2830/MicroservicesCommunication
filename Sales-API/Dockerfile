FROM node:16
WORKDIR .
COPY package*.json ./
RUN npm i
COPY . .
EXPOSE 8082
CMD ["node", "index.js"]