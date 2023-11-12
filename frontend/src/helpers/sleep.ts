export default (sleepTime: number) =>
  new Promise((resolve) => setTimeout(resolve, sleepTime));
