const express = require('express');
const { graphqlHTTP } = require('express-graphql');
const { GraphQLSchema, GraphQLObjectType, GraphQLString, GraphQLInt, GraphQLList } = require('graphql');

const app = express();
const PORT = 3000;

const UserType = new GraphQLObjectType({
  name: 'User',
  fields: {
    id: { type: GraphQLString },
    name: { type: GraphQLString },
    age: { type: GraphQLInt },
    profession: { type: GraphQLString },
  },
});

const PostType = new GraphQLObjectType({
  name: 'Post',
  fields: {
    id: { type: GraphQLString },
    title: { type: GraphQLString },
    content: { type: GraphQLString },
    publishDate: { type: GraphQLString },
  },
});

const rootQueryType = new GraphQLObjectType({
  name: 'Query',
  fields: {
    getUser: {
      type: UserType,
      resolve: () => {
        return {
          id: '1',
          name: 'Maria Gervini',
          age: 30,
          profession: 'Developer',
        };
      },
    },
    getAllPosts: {
      type: new GraphQLList(PostType),
      resolve: () => {
        // Retorna uma lista resumida de posts fictícios
        return [
          {
            title: 'Post 1',
            publishDate: '2023-09-09',
          },
          {
            title: 'Post 2',
            publishDate: '2023-09-08',
          },
        ];
      },
    },
  },
});

const schema = new GraphQLSchema({
  query: rootQueryType,
});

app.use('/graphql', graphqlHTTP({ schema, graphiql: true }));

app.listen(PORT, () => {
  console.log(`Servidor GraphQL rodando em http://localhost:${PORT}/graphql`);
});
