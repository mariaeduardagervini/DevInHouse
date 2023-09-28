const express = require('express');
const { graphqlHTTP } = require('express-graphql');
const { GraphQLSchema, GraphQLObjectType, GraphQLString, GraphQLInt, GraphQLList, GraphQLDirective } = require('graphql');

const app = express();
const PORT = 3000;

const UserType = new GraphQLObjectType({
  name: 'User',
  fields: {
    id: { type: GraphQLString },
    name: { type: GraphQLString },
    age: { type: GraphQLInt },
    profession: { type: GraphQLString },
    email: { type: new GraphQLNonNull(GraphQLString), directives: [{ name: 'email' }] },
  },
});

const EmailValidationDirective = new GraphQLDirective({
  name: 'email',
  locations: [DirectiveLocation.FIELD],
  args: {},
  resolve: (resolve, source, args, context, info) => {
    const value = resolve();
    const emailRegex = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/;
    if (!emailRegex.test(value)) {
      throw new Error(`O valor "${value}" não é um e-mail válido.`);
    }
    return value;
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

const users = [
  { id: '1', name: 'Maria Gervini', age: 30, profession: 'Developer',email: 'maria@email.com' },
  { id: '2', name: 'João Silva', age: 28, profession: 'Designer', email: 'joao@email.com' },
];

const authors = [
  { id: '1', name: 'JK Rowling' },
  { id: '2', name: 'Dan Brown' },
];

const books = [
  { id: '1', title: 'Harry Potter', authorId: '1' },
  { id: '2', title: 'Animais Fantásticos', authorId: '1' },
  { id: '3', title: 'O Código da Vinci', authorId: '2' },
];

const AuthorType = new GraphQLObjectType({
  name: 'Author',
  fields: {
    id: { type: GraphQLString },
    name: { type: GraphQLString },
  },
});

const BookType = new GraphQLObjectType({
  name: 'Book',
  fields: {
    id: { type: GraphQLString },
    title: { type: GraphQLString },
    authorId: { type: GraphQLString },
  },
});


const rootQueryType = new GraphQLObjectType({
  name: 'Query',
  fields: {
    getUser: {
      type: UserType,
      args: {
        id:{ type: GraphQLString }
      },
      resolve: (parent, args) => {
        const { id } = args;
        const user = users.find((user) => user.id === id)
        if(!user) {
          throw new Error(`Usuário com ID ${id} não encontrado`)
        }
        return user;
      },
    },
    getAllPosts: {
      type: new GraphQLList(PostType),
      resolve: () => {
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
      getAuthorBooks: {
        type: new GraphQLList(GraphQLString), 
        args: {
          authorId: { type: GraphQLString },
        },
        resolve: async (parent, args) => {
          const { authorId } = args;
          return books
            .filter((book) => book.authorId === authorId)
            .map((book) => book.title);
        },
      },
    },
  },
});
const rootMutationType = new GraphQLObjectType({
  name: 'Mutation',
  fields: {
    updatePostTitle: {
      type: PostType, 
      args: {
        postId: { type: GraphQLString }, 
        newTitle: { type: GraphQLString }, 
      },
      resolve: (parent, args) => {
        const { postId, newTitle } = args;
        const postToUpdate = posts.find((post) => post.id === postId);
        if (!postToUpdate) {
          return null;
        }
        postToUpdate.title = newTitle;
        return postToUpdate;
      },
    },
  },
});



const schema = new GraphQLSchema({
  query: rootQueryType,
  mutation: rootMutationType,
  directives: [EmailValidationDirective]
});

app.use('/graphql', graphqlHTTP({ schema, graphiql: true }));

app.listen(PORT, () => {
  console.log(`Servidor GraphQL rodando em http://localhost:${PORT}/graphql`);
});
